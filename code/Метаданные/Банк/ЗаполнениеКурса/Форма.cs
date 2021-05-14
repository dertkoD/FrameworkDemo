using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using NsgSoft.Database;





namespace Авто.Метаданные.Банк
{
    
    public partial class ЗаполнениеКурсаФорма

    {
        public ЗаполнениеКурсаФорма()
        {
            InitializeComponent();
		}

		#region #Comments_Data# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Data# NsgSoft.Forms.NsgReportForm

		#region #Comments_Constructors# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Constructors# NsgSoft.Forms.NsgReportForm

		#region #Comments_Methods# NsgSoft.Forms.NsgReportForm
		
        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);

            string url = "http://cbrates.rbc.ru/tsv/cb/" + $"{Валюта.Value.КодВалюты}.tsv";
            HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse();
            StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream());
            var text = strm.ReadToEnd().Split('\n');
            var period = ИсторияКурсов.Новый();

            for (int i = 0; i < text.Length; i++)
            {
                var row = text[i].Split('\t');
                DateTime date = DateTime.ParseExact(row[0], "yyyyMMdd", CultureInfo.InvariantCulture);
                var firstCompare = date.CompareTo(nsgPeriodPicker1.Period.Begin);
                var secondCompare = date.CompareTo(nsgPeriodPicker1.Period.End);
                if ((firstCompare == 1 | secondCompare == -1) & (firstCompare == 1 | secondCompare == 0) & (firstCompare == 1 | secondCompare == 0))
                {
                    period.New();

                    period.ДатаВремя = date;
                    period.Значение = Math.Round(Convert.ToDecimal(row[2], NumberFormatInfo.InvariantInfo), 2);
                    period.Валюта = Валюта.Value;
                    period.Post();
                }
            }

            NsgCompare cmp = new NsgCompare().Add(ИсторияКурсов.Names.Валюта, Валюта.Value.Наименование, NsgComparison.Contain);
            NsgSorting sort = new NsgSorting(new NsgSortingParam(ИсторияКурсов.Names.ДатаВремя, NsgSortDirection.Descending));
            var pole = period.FindAll(cmp);
            var max = pole[pole.Length - 1];

            var currency = Валюты.Новый();
            NsgCompare cmp2 = new NsgCompare().Add(Валюты.Names.Наименование, Валюта.Value.Наименование, NsgComparison.Contain);
            currency.Find(cmp2);
            currency.Edit();
            currency.ТекущийКурс = max.Значение;
            currency.Post();
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }
        
		#endregion //#Comments_Methods# NsgSoft.Forms.NsgReportForm

		#region #Comments_Properties# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Properties# NsgSoft.Forms.NsgReportForm

	}
    


}