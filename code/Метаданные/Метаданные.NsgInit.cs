using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Design;
using System.IO;
using NsgSoft.Common;

namespace Авто.Метаданные
{
    public partial class Метаданные : NsgSoft.DataObjects.NsgMetaData
    {
        #region Данные
        #endregion //Данные

        #region Инициализация


        public static Метаданные Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("f879e99d-a1e9-47bd-9629-be165cfdece1"));
            if (obj == null)
                obj = new Метаданные();
            return obj as Метаданные;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        protected override void InitObjectList()
        {
            ObjectList.AddRange( new NsgMultipleObject[] {Авто.Метаданные.Сервис.DataAssemblyObject.Новый(),
	 Авто.Метаданные.Сервис.БазыДанныхДляОбмена.Новый(),
	 Авто.Метаданные.Сервис.ОбъектыОбмена.Новый(),
	 Авто.Метаданные.Сервис.ТипыОбмена.Новый(),
	 Авто.Метаданные.Сервис.ПравилаОбменаДанными.Новый(),
	 Авто.Метаданные.Сервис.ПротоколОбмена.Новый(),
	 Авто.Метаданные.Сервис.НастройкиКаналаОбмена.Новый(),
	 Авто.Метаданные.Сервис.ОбменДанными.Новый(),
	 Авто.Метаданные.Сервис.ИмпортДанных.Новый(),
	 Авто.Метаданные.Сервис.СервисноеОбслуживание.Новый(),
	 Авто.Метаданные.Сервис.СостоянияОбъекта.Новый(),
	 Авто.Метаданные.Сервис.ВидыДвижений.Новый(),
	 Авто.Метаданные.Сервис.ОбщийЖурнал.Новый(),
	 Авто.Метаданные.Сервис.НеактуальностьИтоговРегистров.Новый(),
	 Авто.Метаданные.Сервис.ПечатныеФормы.Новый(),
	 Авто.Метаданные._SystemTables.СервисПечатныеФормыДвижения.Новый(),
	 Авто.Метаданные.Сервис.КорректировкаРегистра.Новый(),
	 Авто.Метаданные._SystemTables.PeriodicTable.Новый(),
	 Авто.Метаданные.Сервис.ДействияПользователей.Новый(),
	 Авто.Метаданные.Сервис.РазрешениеОперацииПользователя.Новый(),
	 Авто.Метаданные.Сервис.Пользователи.Новый(),
	 Авто.Метаданные._SystemTables.РолиПользователя.Новый(),
	 Авто.Метаданные.Сервис.ТипСообщения.Новый(),
	 Авто.Метаданные.Сервис.СписокСообщений.Новый(),
	 Авто.Метаданные.Сервис.Приоритет.Новый(),
	 Авто.Метаданные.Сервис.ТипЗадачиНаСервере.Новый(),
	 Авто.Метаданные.Сервис.СервернаяЗадача.Новый(),
	 Авто.Метаданные.Сервис.НастройкиПользователей.Новый(),
	 Авто.Метаданные.Сервис.ПраваПользователей.Новый(),
	 Авто.Метаданные._SystemTables.СервисПраваПользователейДвижения.Новый(),
	 Авто.Метаданные.Сервис.ОбновленияСистемы.Новый(),
	 Авто.Метаданные.Сервис.ТаблицаРолиМенюПользователя.Новый(),
	 Авто.Метаданные.Сервис.РольПользователяМеню.Новый(),
	 Авто.Метаданные.Сервис.ДействиеЭлементаМеню.Новый(),
	 Авто.Метаданные.Сервис.ТаблицаЭлементаМенюПользователя.Новый(),
	 Авто.Метаданные.Сервис.ЭлементМенюПользователя.Новый(),
	 Авто.Метаданные.Автосервис.Номенклатура.Новый(),
	 Авто.Метаданные.Автосервис.Контрагенты.Новый(),
	 Авто.Метаданные.Автосервис.ПриходнаяНакладная.Новый(),
	 Авто.Метаданные._SystemTables.АвтосервисПриходнаяНакладнаяТаблица.Новый(),
	 Авто.Метаданные._SystemTables.АвтосервисРасходнаяНакладнаяТаблица.Новый(),
	 Авто.Метаданные.Автосервис.РасходнаяНакладная.Новый(),
	 Авто.Метаданные.Автосервис.Заполнение.Новый(),
	 Авто.Метаданные.Банк.Валюты.Новый(),
	 Авто.Метаданные.Банк.ИсторияКурсов.Новый(),
	 Авто.Метаданные.Банк.ЗаполнениеКурса.Новый()});
        }
        
        /// <summary>
        /// Инициализация
        /// </summary>
        private void InitializeComponent()
        {
            	//NsgMetaData
	IsLoadedFromDll = true;
	Guid = NsgService.StringToGuid("f879e99d-a1e9-47bd-9629-be165cfdece1");
	PeriodicTable = "_SystemTables.PeriodicTable";
	SystemGroup = "_SystemTables";
	Version = "2021.5.12.8";
	ContainsUserInformation = true;
	UserActionsRegisteration = true;
	UseUserMenu = true;
	Groups = new System.String[]{"Сервис", "Автосервис", "Банк"};
	Name = "Метаданные";
	
            AfterLoad();
        }

        #endregion //Инициализация

        #region Свойства
        #endregion //Свойства

        #region Методы
        /// <summary>
        /// Идентификатор текущего уровня метаданных
        /// </summary>
        private string ID
        {
            get
            {
                return "Авто";
            }
        }
        #endregion //Методы
    }
}
