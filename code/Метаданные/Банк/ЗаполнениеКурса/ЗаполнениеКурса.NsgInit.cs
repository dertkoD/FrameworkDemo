using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;

using NsgSoft.DataObjects;
using NsgSoft.Design;
using NsgSoft.Database;
using NsgSoft.Common;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace Авто.Метаданные.Банк
{
    
    [NsgTypeName("NsgReportObject", Guid = "12187fe5-e374-440b-b9af-3713e8212693")]
    public partial class ЗаполнениеКурса : NsgSoft.DataObjects.NsgReportObject
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Данные NsgSoft.DataObjects.NsgReportObject

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgReportObject

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ЗаполнениеКурса()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ЗаполнениеКурса(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ЗаполнениеКурса Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("12187fe5-e374-440b-b9af-3713e8212693"));
            if (obj == null)
                obj = new ЗаполнениеКурса();
            return obj as ЗаполнениеКурса;
        }

        /// <summary>
        /// Инициализация реквизитов объекта
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей
			#region начало инициализации NsgSoft.DataObjects.NsgReportObject
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgReportObject
			
			#region создание System.Guid Идентификатор
			{  
                NsgDataGuid Идентификатор = null;
				if (ObjectList.Contains("Идентификатор"))
                    Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                else
                    Идентификатор = new NsgDataGuid();
	//NsgDataGuid
	Идентификатор.IsLoadedFromDll = true;
	Идентификатор.StringFormat = "";
	Идентификатор.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Идентификатор.IncludeInPredefined = false;
	Идентификатор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Идентификатор.Required = false;
	Идентификатор.EmptyValue = "";
	Идентификатор.NullAllow = false;
	Идентификатор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Идентификатор.FieldName = "_ID";
	Идентификатор.SaveInDatabase = false;
	Идентификатор.InformMetaDataOnValueChanged = false;
	Идентификатор.Visible = true;
	Идентификатор.Name = "Идентификатор";
	Идентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Идентификатор.Description = "Идентификатор";
	Идентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Идентификатор.GroupName = "";
	Идентификатор.Guid = NsgService.StringToGuid("d1ad5de2-6d97-43b5-a16b-edc45dc91673");
	
				if (!ObjectList.Contains("Идентификатор"))
                    ObjectList.Add(Идентификатор);
			}
			#endregion //создание System.Guid Идентификатор
			
			#region создание System.Int64 Автоинкремент
			{  
                NsgDataInteger Автоинкремент = null;
				if (ObjectList.Contains("Автоинкремент"))
                    Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                else
                    Автоинкремент = new NsgDataInteger();
	//NsgDataInteger
	Автоинкремент.IsLoadedFromDll = true;
	Автоинкремент.DefaultValue = 0M;
	Автоинкремент.MinValue = 0M;
	Автоинкремент.MaxValue = 0M;
	Автоинкремент.UseCalculator = true;
	Автоинкремент.StringFormat = "";
	Автоинкремент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Автоинкремент.IncludeInPredefined = false;
	Автоинкремент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автоинкремент.Required = false;
	Автоинкремент.EmptyValue = "";
	Автоинкремент.NullAllow = false;
	Автоинкремент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Автоинкремент.FieldName = "_AutoInc";
	Автоинкремент.SaveInDatabase = false;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("16083073-770b-4f14-9f38-99655b44cd87");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание Авто.Метаданные.Банк.ЗаполнениеКурсаФорма Форма
			{  
                NsgDataForm Форма = null;
				if (ObjectList.Contains("Форма"))
                    Форма = ObjectList["Форма"] as NsgDataForm;
                else
                    Форма = new NsgDataForm();
	//NsgDataForm
	Форма.IsLoadedFromDll = true;
	Форма.FormClassName = "Авто.Метаданные.Банк.ЗаполнениеКурсаФорма";
	Форма.SaveInDatabase = false;
	Форма.StringFormat = "";
	Форма.SubType = NsgSoft.Common.NsgRekvisitSubType.ElementForm;
	Форма.IncludeInPredefined = false;
	Форма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Форма.Required = false;
	Форма.EmptyValue = "";
	Форма.NullAllow = false;
	Форма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Форма.FieldName = "Forma";
	Форма.InformMetaDataOnValueChanged = false;
	Форма.Visible = true;
	Форма.Name = "Форма";
	Форма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Форма.Description = "Форма";
	Форма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Форма.GroupName = "";
	Форма.Guid = NsgService.StringToGuid("f6e57ab9-9e33-4cab-9d92-381fba56cd02");
	
				if (!ObjectList.Contains("Форма"))
                    ObjectList.Add(Форма);
			}
			#endregion //создание Авто.Метаданные.Банк.ЗаполнениеКурсаФорма Форма
			
			#region создание Банк.Валюты Валюта
			{  
                NsgDataTypedReference Валюта = null;
				if (ObjectList.Contains("Валюта"))
                    Валюта = ObjectList["Валюта"] as NsgDataTypedReference;
                else
                    Валюта = new NsgDataTypedReference();
	//NsgDataTypedReference
	Валюта.IsLoadedFromDll = true;
	Валюта.ReferentGroup = "Банк";
	Валюта.ReferentName = "Валюты";
	Валюта.SaveInDatabase = false;
	Валюта.OwnerName = "";
	Валюта.AllowEmptyOwner = false;
	Валюта.StringFormat = "";
	Валюта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Валюта.IncludeInPredefined = false;
	Валюта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Валюта.Required = false;
	Валюта.EmptyValue = "";
	Валюта.NullAllow = false;
	Валюта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Валюта.FieldName = "Valjuty";
	Валюта.InformMetaDataOnValueChanged = false;
	Валюта.Visible = true;
	Валюта.Name = "Валюта";
	Валюта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Валюта.Description = "Валюта";
	Валюта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Валюта.GroupName = "";
	Валюта.Guid = NsgService.StringToGuid("5aa981e4-e40b-4939-96f1-7dfd7d0e87d7");
	
				if (!ObjectList.Contains("Валюта"))
                    ObjectList.Add(Валюта);
			}
			#endregion //создание Банк.Валюты Валюта
			

			#region заполнение полей класса
				//NsgReportObject
	IsLoadedFromDll = true;
	Name = "ЗаполнениеКурса";
	Visible = true;
	Guid = NsgService.StringToGuid("12187fe5-e374-440b-b9af-3713e8212693");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "Ав_report_ZapolnenieKursa";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Отчет";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Банк";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgReportObject
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgReportObject

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgReportObject.Names
        {
            
            /// <summary>
            /// Идентификатор
            /// </summary>
            public static String Идентификатор
            {
                get
                {
                    return "Идентификатор";
                }
            }
            
            /// <summary>
            /// Автоинкремент
            /// </summary>
            public static String Автоинкремент
            {
                get
                {
                    return "Автоинкремент";
                }
            }
            
            /// <summary>
            /// Форма
            /// </summary>
            public static String Форма
            {
                get
                {
                    return "Форма";
                }
            }
            
            /// <summary>
            /// Валюта
            /// </summary>
            public static String Валюта
            {
                get
                {
                    return "Валюта";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public override NsgMultipleObjectDescriptor Descriptor
        {
            get
            {
                if (descriptor == null)
                {
                    descriptor = new NsgMultipleObjectDescriptor();
                    descriptor.Name = "ЗаполнениеКурса";
                    descriptor.GroupName = "Банк";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Банк.ЗаполнениеКурса";
        }

        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid Идентификатор
        {
            get
            {
				 NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                 return (System.Guid)__Идентификатор.Value;
            }
            set
            {
                NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                __Идентификатор.Value = value;
            }
        }
        
        /// <summary>
        /// Автоинкремент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Автоинкремент
        {
            get
            {
				 NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                 return (System.Int64)__Автоинкремент.Value;
            }
            set
            {
                NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                __Автоинкремент.Value = value;
            }
        }
        
        /// <summary>
        /// Валюта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Банк.Валюты Валюта
        {
            get
            {
				 NsgDataTypedReference __Валюта = ObjectList["Валюта"] as NsgDataTypedReference;
                 return (Банк.Валюты)__Валюта.Referent;
            }
            set
            {
                NsgDataTypedReference __Валюта = ObjectList["Валюта"] as NsgDataTypedReference;
                __Валюта.Referent = value;
            }
        }
        

        
        /// <summary>
        /// Форма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm Форма
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["Форма"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"Форма");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"Форма");
                return res;
           }
        }
        
        #region Свойства NsgSoft.DataObjects.NsgReportObject
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgReportObject

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Методы NsgSoft.DataObjects.NsgReportObject

        #region Методы NsgMultipleObject
        private ЗаполнениеКурса[] convertArray(NsgMultipleObject[] array)
        {
            ЗаполнениеКурса[] res = new ЗаполнениеКурса[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск множества результатов на полное совпадение. Перегруженные методы.
        /// <summary>
        /// Метод поиска в БД по одному и более реквизитов с ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        /// </remarks>
        /// <param name="compare">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ЗаполнениеКурса[] FindAll(NsgCompare compare)
        {
            return convertArray(base.FindAll(compare));
        }

        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному и более реквизитов
        ///  c ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="paramAll">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ЗаполнениеКурса[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, compare));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Имя реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ЗаполнениеКурса[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Идентификатор реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ЗаполнениеКурса[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ЗаполнениеКурса(this as NsgObject);
            }
        }

        #endregion // Методы NsgMultipleObject
        #endregion // Методы

        /// <summary>
        /// Описатель колонки источника данных
        /// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(ЗаполнениеКурса);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ЗаполнениеКурса Value
            {
                get
                {
                    return (ЗаполнениеКурса)base.Value;
                }
                set
                {
                    base.Value = value;
                }
            }

            /// <summary>
            /// Имя иконки колонки
            /// </summary>
            public override string ImageKey
            {
                get
                {
                    return "s_NsgReportObject";
                }
            }
        }

    }

}
