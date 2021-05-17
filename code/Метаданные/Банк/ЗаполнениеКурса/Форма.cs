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

            string url = "http://cbrates.rbc.ru/tsv/cb/" + $"{Валюта.Value.КодВалюты}.tsv"; // создаем переменную url в которой хранится адрес сайта
            HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create(url); // выполняем запрос по указонному адресу 
            HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse(); // получаем ответ
            StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream()); // создаем считыватель
            var text = strm.ReadToEnd().Split('\n'); // записываем данные с сайта в массив удаляя enter, тем самым получая массив с одной строкой
            var period = ИсторияКурсов.Новый(); // создаем объект 

            for (int i = 0; i < text.Length; i++) // цикл для перебора массива text 
            {
                var row = text[i].Split('\t'); // записываем данные в массив удаляя отступы и получая массив с тремя элементами
                DateTime date = DateTime.ParseExact(row[0], "yyyyMMdd", CultureInfo.InvariantCulture); // преобрауем 1-ый элемент массива в тип DateTime
                var firstCompare = date.CompareTo(nsgPeriodPicker1.Period.Begin); // сравниваем date с данными из PeriodPicker
                var secondCompare = date.CompareTo(nsgPeriodPicker1.Period.End); // --//--
                if ((firstCompare == 1 | secondCompare == -1) & (firstCompare == 1 | secondCompare == 0) & (firstCompare == 1 | secondCompare == 0))
                {
                    period.New(); // создаем новые строки объекста period

                    period.ДатаВремя = date; // присваиваем полю ДатаВремя переменную date
                    period.Значение = Math.Round(Convert.ToDecimal(row[2], NumberFormatInfo.InvariantInfo), 2); // присваиваем полю Значение 3-ий элемент массива конвертируя его в тип decimal и округляя до 2 знаков после запятой
                    period.Валюта = Валюта.Value; // присваиваем полю Валюта поле Валюта
                    period.Post(); // связываем с БД
                }
            }

            NsgCompare cmp = new NsgCompare().Add(ИсторияКурсов.Names.Валюта, Валюта.Value.Наименование, NsgComparison.Contain); // добавляем в сравнение новое условие сравнения поля Валюты из объекта ИсторияКурсов и поля Валюта из объекта ЗаполнениеКурса
            NsgSorting sort = new NsgSorting(new NsgSortingParam(ИсторияКурсов.Names.ДатаВремя, NsgSortDirection.Descending)); // сортируем по ... полю ДатаВремя наверное????
            var pole = period.FindAll(cmp); // получаем массив объектов с условием которое записано в переменной cmp
            var max = pole[pole.Length - 1]; // берем последний элемент массива pole

            var currency = Валюты.Новый(); // создаем объект
            NsgCompare cmp2 = new NsgCompare().Add(Валюты.Names.Наименование, Валюта.Value.Наименование, NsgComparison.Contain); // добавляем в сравнение новое условие сравнения поля Наименования из объекта Валюты и поля Валюта из объекта ЗаполнениеКурса
            currency.Find(cmp2); //  заполняем объект из БД по условию cmp2
            currency.Edit(); // переводим объект в режим редактирования 
            currency.ТекущийКурс = max.Значение; // изменяем значение поля ТекущийКурс на значение поля Значение объекта ИсторияКурсов
            currency.Post(); // связываем с БД
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