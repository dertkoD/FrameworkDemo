using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace Авто.Метаданные.Автосервис

{
    
    public partial class НоменклатураФормаСписка:NsgSoft.Forms.NsgMultipleObjectBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoГруппы = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ЭтоГруппа_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ИдентификаторРодителя_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Уровень_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.Byte();
            this.ПрефиксКода_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерКода_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Код_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Наименование_vmoГруппы = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СостояниеДокумента_vmoГруппы = new Авто.Метаданные.Сервис.СостоянияОбъекта.ColumnDescriptor();
            this.Родитель_vmoГруппы = new Авто.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.Идентификатор = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ЭтоГруппа = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ИдентификаторРодителя = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Уровень = new NsgSoft.Forms.NsgColumnDescriptor.Byte();
            this.ПрефиксКода = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерКода = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Код = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Наименование = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СостояниеДокумента = new Авто.Метаданные.Сервис.СостоянияОбъекта.ColumnDescriptor();
            this.Родитель = new Авто.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoГруппы)).BeginInit();
            this.SuspendLayout();
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "Авто";
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Автосервис.Номенклатура.ИдентификаторРодителя";
            // 
            // nsgVisualMultipleObject
            // 
            nsgObjectDescriptor1.ConfigurationName = "Авто";
            nsgObjectDescriptor1.FullName = "Автосервис.Номенклатура.ИдентификаторРодителя";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Автосервис.Номенклатура.Идентификатор";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Hierarchy;
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Идентификатор);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Автоинкремент);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЭтоГруппа);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ИдентификаторРодителя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Уровень);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПрефиксКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Код);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Наименование);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СостояниеДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MasterComponent = this.vmoГруппы;
            this.nsgVisualMultipleObject.Binding = nsgMasterDetailBinding1;
            // 
            // nsgIGrid1
            // 
            this.nsgIGrid1.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid1.AllowSaveColParamsToXML = true;
            this.nsgIGrid1.AllowSaveColPositionToXML = true;
            this.nsgIGrid1.AllowSaveColWidthToXML = true;
            this.nsgIGrid1.AllowSaveSettingsToXML = true;
            this.nsgIGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGrid1.AutoResizeCols = true;
            nsgIGridColumn1.AllowFilter = true;
            nsgIGridColumn1.AllowGroupSelect = false;
            nsgIGridColumn1.AllowResize = true;
            nsgIGridColumn1.AutoResize = true;
            nsgIGridColumn1.Caption = "";
            nsgIGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.InitiateRowEdit = true;
            nsgIGridColumn1.Name = "Код";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn1.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn1.UseAsHeaderImage = false;
            nsgIGridColumn1.Width = 100;
            nsgIGridColumn2.AllowFilter = true;
            nsgIGridColumn2.AllowGroupSelect = false;
            nsgIGridColumn2.AllowResize = true;
            nsgIGridColumn2.AutoResize = true;
            nsgIGridColumn2.Caption = "";
            nsgIGridColumn2.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn2.DateFormat = null;
            nsgIGridColumn2.InitiateRowEdit = true;
            nsgIGridColumn2.Name = "Наименование";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn2.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn2.UseAsHeaderImage = false;
            nsgIGridColumn2.Width = 100;
            nsgIGridColumn3.AllowFilter = true;
            nsgIGridColumn3.AllowGroupSelect = false;
            nsgIGridColumn3.AllowResize = true;
            nsgIGridColumn3.AutoResize = true;
            nsgIGridColumn3.Caption = "";
            nsgIGridColumn3.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.InitiateRowEdit = true;
            nsgIGridColumn3.Name = "СостояниеДокумента";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Visible = false;
            nsgIGridColumn3.Width = 100;
            nsgIGridColumn4.AllowFilter = true;
            nsgIGridColumn4.AllowGroupSelect = false;
            nsgIGridColumn4.AllowResize = true;
            nsgIGridColumn4.AutoResize = true;
            nsgIGridColumn4.Caption = "";
            nsgIGridColumn4.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.InitiateRowEdit = true;
            nsgIGridColumn4.Name = "Родитель";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Visible = false;
            nsgIGridColumn4.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(7, 14);
            this.nsgIGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nsgIGrid1.MarkReadOnly = false;
            this.nsgIGrid1.MasterObject = this.vmoГруппы;
            this.nsgIGrid1.Name = "NsgIGrid";
            this.nsgIGrid1.PageSelector = false;
            this.nsgIGrid1.ReadOnly = false;
            this.nsgIGrid1.RowChangeInterval = 200;
            this.nsgIGrid1.RowHeaderImageList = null;
            this.nsgIGrid1.RowMode = false;
            this.nsgIGrid1.ScrollWidth = 0;
            this.nsgIGrid1.SelectedRow = -1;
            this.nsgIGrid1.ShowHeader = true;
            this.nsgIGrid1.ShowLineImages = true;
            this.nsgIGrid1.ShowLineNumbers = false;
            this.nsgIGrid1.ShowPanel = true;
            this.nsgIGrid1.ShowTotals = false;
            this.nsgIGrid1.ShowTree = true;
            this.nsgIGrid1.Size = new System.Drawing.Size(641, 446);
            this.nsgIGrid1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgIGrid1.TabIndex = 9;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoГруппы
            // 
            this.vmoГруппы.Columns.Collection.Add(this.Идентификатор_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.Автоинкремент_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.ЭтоГруппа_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.ИдентификаторРодителя_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.Уровень_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.ПрефиксКода_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.НомерКода_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.Код_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.Наименование_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.СостояниеДокумента_vmoГруппы);
            this.vmoГруппы.Columns.Collection.Add(this.Родитель_vmoГруппы);
            this.vmoГруппы.MetaDataName = "Метаданные";
            this.vmoГруппы.FullName = "Автосервис.Номенклатура";
            // 
            // Идентификатор_vmoГруппы
            // 
            this.Идентификатор_vmoГруппы.AutoGenerated = true;
            this.Идентификатор_vmoГруппы.Caption = "Идентификатор";
            this.Идентификатор_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Идентификатор_vmoГруппы.Name = "Идентификатор";
            this.Идентификатор_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoГруппы.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoГруппы.SearchCondition.OwnerComponent = this.Идентификатор_vmoГруппы;
            this.Идентификатор_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoГруппы.Visible = false;
            // 
            // Автоинкремент_vmoГруппы
            // 
            this.Автоинкремент_vmoГруппы.AutoGenerated = true;
            this.Автоинкремент_vmoГруппы.CalcTotal = false;
            this.Автоинкремент_vmoГруппы.Caption = "Автоинкремент";
            this.Автоинкремент_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Автоинкремент_vmoГруппы.Name = "Автоинкремент";
            this.Автоинкремент_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoГруппы.PropertyType = typeof(long);
            this.Автоинкремент_vmoГруппы.SearchCondition.OwnerComponent = this.Автоинкремент_vmoГруппы;
            this.Автоинкремент_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoГруппы.Visible = false;
            // 
            // ЭтоГруппа_vmoГруппы
            // 
            this.ЭтоГруппа_vmoГруппы.AutoGenerated = true;
            this.ЭтоГруппа_vmoГруппы.Caption = "ЭтоГруппа";
            this.ЭтоГруппа_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ЭтоГруппа_vmoГруппы.Name = "ЭтоГруппа";
            this.ЭтоГруппа_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЭтоГруппа_vmoГруппы.PropertyType = typeof(bool);
            this.ЭтоГруппа_vmoГруппы.SearchCondition.OwnerComponent = this.ЭтоГруппа_vmoГруппы;
            this.ЭтоГруппа_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ЭтоГруппа_vmoГруппы.Visible = false;
            // 
            // ИдентификаторРодителя_vmoГруппы
            // 
            this.ИдентификаторРодителя_vmoГруппы.AutoGenerated = true;
            this.ИдентификаторРодителя_vmoГруппы.Caption = "ИдентификаторРодителя";
            this.ИдентификаторРодителя_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ИдентификаторРодителя_vmoГруппы.Name = "ИдентификаторРодителя";
            this.ИдентификаторРодителя_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.ИдентификаторРодителя_vmoГруппы.PropertyType = typeof(System.Guid);
            this.ИдентификаторРодителя_vmoГруппы.SearchCondition.OwnerComponent = this.ИдентификаторРодителя_vmoГруппы;
            this.ИдентификаторРодителя_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ИдентификаторРодителя_vmoГруппы.Visible = false;
            // 
            // Уровень_vmoГруппы
            // 
            this.Уровень_vmoГруппы.AutoGenerated = true;
            this.Уровень_vmoГруппы.Caption = "Уровень";
            this.Уровень_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Уровень_vmoГруппы.Name = "Уровень";
            this.Уровень_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataByte);
            this.Уровень_vmoГруппы.PropertyType = typeof(byte);
            this.Уровень_vmoГруппы.SearchCondition.OwnerComponent = this.Уровень_vmoГруппы;
            this.Уровень_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Уровень_vmoГруппы.Visible = false;
            // 
            // ПрефиксКода_vmoГруппы
            // 
            this.ПрефиксКода_vmoГруппы.AutoGenerated = true;
            this.ПрефиксКода_vmoГруппы.Caption = "ПрефиксКода";
            this.ПрефиксКода_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ПрефиксКода_vmoГруппы.Name = "ПрефиксКода";
            this.ПрефиксКода_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ПрефиксКода_vmoГруппы.PropertyType = typeof(string);
            this.ПрефиксКода_vmoГруппы.SearchCondition.OwnerComponent = this.ПрефиксКода_vmoГруппы;
            this.ПрефиксКода_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ПрефиксКода_vmoГруппы.Visible = false;
            // 
            // НомерКода_vmoГруппы
            // 
            this.НомерКода_vmoГруппы.AutoGenerated = true;
            this.НомерКода_vmoГруппы.CalcTotal = false;
            this.НомерКода_vmoГруппы.Caption = "НомерКода";
            this.НомерКода_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.НомерКода_vmoГруппы.Name = "НомерКода";
            this.НомерКода_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерКода_vmoГруппы.PropertyType = typeof(long);
            this.НомерКода_vmoГруппы.SearchCondition.OwnerComponent = this.НомерКода_vmoГруппы;
            this.НомерКода_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерКода_vmoГруппы.Visible = false;
            // 
            // Код_vmoГруппы
            // 
            this.Код_vmoГруппы.AutoGenerated = true;
            this.Код_vmoГруппы.Caption = "Код";
            this.Код_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Код_vmoГруппы.Name = "Код";
            this.Код_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Код_vmoГруппы.PropertyType = typeof(string);
            this.Код_vmoГруппы.SearchCondition.OwnerComponent = this.Код_vmoГруппы;
            this.Код_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование_vmoГруппы
            // 
            this.Наименование_vmoГруппы.AutoGenerated = true;
            this.Наименование_vmoГруппы.Caption = "Наименование";
            this.Наименование_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Наименование_vmoГруппы.Name = "Наименование";
            this.Наименование_vmoГруппы.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование_vmoГруппы.PropertyType = typeof(string);
            this.Наименование_vmoГруппы.SearchCondition.OwnerComponent = this.Наименование_vmoГруппы;
            this.Наименование_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СостояниеДокумента_vmoГруппы
            // 
            this.СостояниеДокумента_vmoГруппы.AutoGenerated = true;
            this.СостояниеДокумента_vmoГруппы.Caption = "СостояниеДокумента";
            this.СостояниеДокумента_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.СостояниеДокумента_vmoГруппы.Name = "СостояниеДокумента";
            this.СостояниеДокумента_vmoГруппы.NSGType = typeof(Авто.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента_vmoГруппы.PropertyType = typeof(Авто.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента_vmoГруппы.SearchCondition.OwnerComponent = this.СостояниеДокумента_vmoГруппы;
            this.СостояниеДокумента_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель_vmoГруппы
            // 
            this.Родитель_vmoГруппы.AutoGenerated = true;
            this.Родитель_vmoГруппы.Caption = "Родитель";
            this.Родитель_vmoГруппы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Родитель_vmoГруппы.Name = "Родитель";
            this.Родитель_vmoГруппы.NSGType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.Родитель_vmoГруппы.PropertyType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.Родитель_vmoГруппы.SearchCondition.OwnerComponent = this.Родитель_vmoГруппы;
            this.Родитель_vmoГруппы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Идентификатор
            // 
            this.Идентификатор.AutoGenerated = true;
            this.Идентификатор.Caption = "Идентификатор";
            this.Идентификатор.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Идентификатор.Name = "Идентификатор";
            this.Идентификатор.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор.PropertyType = typeof(System.Guid);
            this.Идентификатор.SearchCondition.OwnerComponent = this.Идентификатор;
            this.Идентификатор.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор.Visible = false;
            // 
            // Автоинкремент
            // 
            this.Автоинкремент.AutoGenerated = true;
            this.Автоинкремент.CalcTotal = false;
            this.Автоинкремент.Caption = "Автоинкремент";
            this.Автоинкремент.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Автоинкремент.Name = "Автоинкремент";
            this.Автоинкремент.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент.PropertyType = typeof(long);
            this.Автоинкремент.SearchCondition.OwnerComponent = this.Автоинкремент;
            this.Автоинкремент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент.Visible = false;
            // 
            // ЭтоГруппа
            // 
            this.ЭтоГруппа.AutoGenerated = true;
            this.ЭтоГруппа.Caption = "ЭтоГруппа";
            this.ЭтоГруппа.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ЭтоГруппа.Name = "ЭтоГруппа";
            this.ЭтоГруппа.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЭтоГруппа.PropertyType = typeof(bool);
            this.ЭтоГруппа.SearchCondition.OwnerComponent = this.ЭтоГруппа;
            this.ЭтоГруппа.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ЭтоГруппа.Visible = false;
            // 
            // ИдентификаторРодителя
            // 
            this.ИдентификаторРодителя.AutoGenerated = true;
            this.ИдентификаторРодителя.Caption = "ИдентификаторРодителя";
            this.ИдентификаторРодителя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ИдентификаторРодителя.Name = "ИдентификаторРодителя";
            this.ИдентификаторРодителя.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.ИдентификаторРодителя.PropertyType = typeof(System.Guid);
            this.ИдентификаторРодителя.SearchCondition.OwnerComponent = this.ИдентификаторРодителя;
            this.ИдентификаторРодителя.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ИдентификаторРодителя.Visible = false;
            // 
            // Уровень
            // 
            this.Уровень.AutoGenerated = true;
            this.Уровень.Caption = "Уровень";
            this.Уровень.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Уровень.Name = "Уровень";
            this.Уровень.NSGType = typeof(NsgSoft.DataObjects.NsgDataByte);
            this.Уровень.PropertyType = typeof(byte);
            this.Уровень.SearchCondition.OwnerComponent = this.Уровень;
            this.Уровень.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Уровень.Visible = false;
            // 
            // ПрефиксКода
            // 
            this.ПрефиксКода.AutoGenerated = true;
            this.ПрефиксКода.Caption = "ПрефиксКода";
            this.ПрефиксКода.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ПрефиксКода.Name = "ПрефиксКода";
            this.ПрефиксКода.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ПрефиксКода.PropertyType = typeof(string);
            this.ПрефиксКода.SearchCondition.OwnerComponent = this.ПрефиксКода;
            this.ПрефиксКода.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ПрефиксКода.Visible = false;
            // 
            // НомерКода
            // 
            this.НомерКода.AutoGenerated = true;
            this.НомерКода.CalcTotal = false;
            this.НомерКода.Caption = "НомерКода";
            this.НомерКода.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.НомерКода.Name = "НомерКода";
            this.НомерКода.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерКода.PropertyType = typeof(long);
            this.НомерКода.SearchCondition.OwnerComponent = this.НомерКода;
            this.НомерКода.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерКода.Visible = false;
            // 
            // Код
            // 
            this.Код.AutoGenerated = true;
            this.Код.Caption = "Код";
            this.Код.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Код.Name = "Код";
            this.Код.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Код.PropertyType = typeof(string);
            this.Код.SearchCondition.OwnerComponent = this.Код;
            this.Код.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование
            // 
            this.Наименование.AutoGenerated = true;
            this.Наименование.Caption = "Наименование";
            this.Наименование.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Наименование.Name = "Наименование";
            this.Наименование.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование.PropertyType = typeof(string);
            this.Наименование.SearchCondition.OwnerComponent = this.Наименование;
            this.Наименование.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СостояниеДокумента
            // 
            this.СостояниеДокумента.AutoGenerated = true;
            this.СостояниеДокумента.Caption = "СостояниеДокумента";
            this.СостояниеДокумента.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.СостояниеДокумента.Name = "СостояниеДокумента";
            this.СостояниеДокумента.NSGType = typeof(Авто.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента.PropertyType = typeof(Авто.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента.SearchCondition.OwnerComponent = this.СостояниеДокумента;
            this.СостояниеДокумента.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.Родитель.PropertyType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НоменклатураФормаСписка
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.nsgIGrid1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(22, 22);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgMultipleObjectBaseForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "Форма объекта";
            this.Controls.SetChildIndex(this.nsgIGrid1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoГруппы)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected NsgIGrid nsgIGrid1;
        private NsgColumnDescriptor.Guid Идентификатор;
        private NsgColumnDescriptor.Int64 Автоинкремент;
        private NsgColumnDescriptor.Boolean ЭтоГруппа;
        private NsgColumnDescriptor.Guid ИдентификаторРодителя;
        private NsgColumnDescriptor.Byte Уровень;
        private NsgColumnDescriptor.String ПрефиксКода;
        private NsgColumnDescriptor.Int64 НомерКода;
        private NsgColumnDescriptor.String Код;
        private NsgColumnDescriptor.String Наименование;
        private Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        protected Номенклатура.ColumnDescriptor Родитель;
        protected NsgVisualMultipleObject vmoГруппы;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoГруппы;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoГруппы;
        protected NsgColumnDescriptor.Boolean ЭтоГруппа_vmoГруппы;
        protected NsgColumnDescriptor.Guid ИдентификаторРодителя_vmoГруппы;
        protected NsgColumnDescriptor.Byte Уровень_vmoГруппы;
        protected NsgColumnDescriptor.String ПрефиксКода_vmoГруппы;
        protected NsgColumnDescriptor.Int64 НомерКода_vmoГруппы;
        protected NsgColumnDescriptor.String Код_vmoГруппы;
        protected NsgColumnDescriptor.String Наименование_vmoГруппы;
        protected Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента_vmoГруппы;
        protected Номенклатура.ColumnDescriptor Родитель_vmoГруппы;
    }
}