using ExceptionHandler;
using hotelprocessing.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelprocessing
{
    public static class HotelCreator
    {
        /// <summary>
        /// Entity, соединение с бд
        /// </summary>
        public static HotelDBEntities EntityConnection = new HotelDBEntities();

        #region AddOrUpdate        
        /// <summary>
        /// Добавить или обновить запись об отеле
        /// </summary>
        /// <param name="value">Отель который мы добавляем</param>
        /// <returns>Возвращает добавленную или обновленную запись</returns>
        /// <exception cref="ArgumentException"
        /// <exception cref="MyException"
        public static HotelInfo AddOrUpdate(HotelInfo value)
        {           
            
            if (value == null)
                throw new ArgumentException("HotelInfo is null");
            try
            {
                if (IsContains(value))
                {
                    HotelInfo existingHotel = EntityConnection.HotelInfoes.Where(x => x.Id == value.Id).First();

                    if (existingHotel != null)
                    {
                        existingHotel = value;
                        return existingHotel;
                    }
                    else
                        throw new MyException("HotelWorker.HotelCreator.AddOrUpdateHotel()"); // Логирование ошибок
                }
                else
                {
                    var tempHotel = EntityConnection.HotelInfoes.Add(value);
                    tempHotel.HotelWorker = AddOrUpdate(tempHotel.HotelWorker);
                    tempHotel.HotelWorker.HotelID = tempHotel.Id;
                    tempHotel.HotelWorker.HotelInfo = tempHotel;
                    return tempHotel;
                }

            }
            finally
            {
                EntityConnection.SaveChanges();
            }
        }

        /// <summary>
        /// Добавить или обновить запись об постояльцах
        /// </summary>
        /// <param name="parent">Постоялец, на которго регистрируем</param>
        /// <param name="childs">Со-жители проживающие вместе с постояльцем</param>
        /// <returns>Возвращает постояльца с сожителями</returns>
        /// <exception cref="ArgumentException"
        /// <exception cref="MyException"
        public static Guest AddOrUpdate(Guest parent)
        {            
            if (parent == null)
            {
                throw new ArgumentException("Guest parent is null");
            }
            
            try
            {
                if (IsContains(parent))
                {
                    Guest existingModel = EntityConnection.Guests.Where(x => x.Id == parent.Id).First();

                    if (existingModel != null)
                    {                        
                        existingModel = parent;
                        return existingModel;
                    }
                    else
                    {
                        throw new MyException("HotelWorker.HotelCreator.AddOrUpdateGuest()");
                    }
                }
                else
                {
                    return EntityConnection.Guests.Add(parent);
                }
            }
            finally
            {
                EntityConnection.SaveChanges();
            }

        }        
        public static Guest AddOrUpdate(Guest parent, ICollection<Child_Guest> childs)
        {
            if (parent == null)
            {
                throw new ArgumentException("Guest parent is null");
            }

            try
            {
                if (IsContains(parent))
                {
                    Guest existingModel = EntityConnection.Guests.Where(x => x.Id == parent.Id).First();

                    if (existingModel != null)
                    {
                        existingModel = parent;
                        existingModel.Child_Guest = childs;
                        return existingModel;
                    }
                    else
                    {
                        throw new MyException("HotelWorker.HotelCreator.AddOrUpdateGuest()");
                    }
                }
                else
                {
                    parent.Child_Guest = childs;

                    var model = EntityConnection.Guests.Add(parent);
                    
                    foreach (var ch in parent.Child_Guest)
                    {
                        ch.ParentID = model.Id;
                    }

                    return model;
                }
            }
            finally
            {
                EntityConnection.SaveChanges();
            }

        }
             
        /// <summary>
        /// Добавить или обновить работника отеля
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"
        /// <exception cref="MyException"
        public static HotelWorker AddOrUpdate(HotelWorker value)
        {
            if (value == null)
            {
                throw new ArgumentException("HotelWorker is null");
            }
            try
            {           
                if (IsContains(value))
                {
                    HotelWorker existingModel = EntityConnection.HotelWorkers.Where(x => x.Id == value.Id).First();

                    if (existingModel != null)
                    {
                        existingModel = value;
                        return existingModel;
                    }
                    else
                    {
                        throw new MyException("HotelWorker.HotelCreator.AddOrUpdateHotelNumber()");
                    }
                }
                else
                {
                    return EntityConnection.HotelWorkers.Add(value);
                }
            }
            finally
            {
                EntityConnection.SaveChanges();
            }
        }
        public static RoomType AddOrUpdate(RoomType value)
        {
            if (value == null)
                throw new NullReferenceException("RoomType value is null");
            try
            {
                if (IsContains(value)) //UPDATE
                {
                    RoomType existingModel = EntityConnection.RoomTypes.Where(x => x.Level.Equals(value.Level)).First();

                    if (existingModel == null)
                    {
                        throw new NullReferenceException("existingModel value is null");
                    }
                    else
                    {   
                        return existingModel = value;
                    }
                }
                else // ADD
                {
                    return EntityConnection.RoomTypes.Add(value);
                }
            }
            finally
            {
                EntityConnection.SaveChanges();
            }
        }
        public static HotelFurniture AddOrUpdate(HotelFurniture value)
        {
            if (value == null)
                throw new NullReferenceException("HotelFurniture value is null");
            try
            {
                if (IsContains(value)) //UPDATE
                {
                    HotelFurniture existingModel = EntityConnection.HotelFurnitures.Where(x => x.Name.Equals(value.Name)).First();
                    if (existingModel == null)
                    {
                        throw new NullReferenceException("existingModel value is null");
                    }
                    else
                    {
                        return existingModel = value;
                    }
                }
                else // ADD
                {
                    return EntityConnection.HotelFurnitures.Add(value);
                }
            }
            finally
            {
                EntityConnection.SaveChanges();
            }
        }
        public static HotelNumber AddOrUpdate(HotelNumber value)
        {
            if (value == null)
                throw new NullReferenceException("HotelFurniture value is null");
            try
            {
                if (IsContains(value)) //UPDATE
                {
                    HotelNumber existingModel = EntityConnection.HotelNumbers.Where(x => x.RoomIndex == value.RoomIndex && x.FloorIndex == value.FloorIndex && x.HotelID == value.HotelID).First();

                    if (existingModel == null)
                    {
                        throw new NullReferenceException("existingModel value is null");
                    }
                    else
                    {
                        return existingModel = value;
                    }
                }
                else // ADD
                {
                    return EntityConnection.HotelNumbers.Add(value);
                }
            }
            finally
            {
                EntityConnection.SaveChanges();
            }
        }
        
        /// <summary>
        /// Обновляем список номеров по этажам
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static List<HotelNumber> AddOrUpdate(List<HotelNumber> collection)
        {
            try
            {
                var oldColl = EntityConnection.HotelNumbers.AsEnumerable().Where(x => x.HotelID == collection[0].HotelID && x.FloorIndex == collection[0].FloorIndex).ToList();
                
                foreach (var item in oldColl)
                {
                    if (!IsExists(item, collection))
                    {
                        EntityConnection.HotelNumbers.Remove(item);
                    }
                }

                foreach (var item in collection)
                {
                    if (!IsExists(item, oldColl))
                    {
                        item.HotelID = oldColl[0].HotelID;

                        EntityConnection.HotelNumbers.Add(item);
                    }
                }

                return EntityConnection.HotelNumbers.AsEnumerable().Where(x => x.HotelID == collection[0].HotelID && x.FloorIndex == collection[0].FloorIndex).ToList();
            }
            finally
            {
                EntityConnection.SaveChanges();
            }
        }
     
        /// <summary>
        /// Добавить гостя в отель по определенному номеру
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="number"></param>
        /// <param name="guest"></param>
        public static void AddGuestToHotel(HotelInfo hotel, HotelNumber number, Guest guest)
        {
            if (hotel == null || guest == null)
                throw new NullReferenceException("hotel or guest is null");

            number.IsEmpty = false;
            number.Guest = guest;
            if (!IsContains(guest))
                hotel.Guests.Add(guest);           

            EntityConnection.SaveChanges();
        }
        #endregion

        #region Remove
        /// <summary>
        /// Удаляем элементы из БД мебели
        /// </summary>
        /// <param name="arr">Список мебели для удаления</param>
        public static void RemoveRange(ICollection<HotelFurniture> arr)
        {
            foreach (var item in arr)
            {
                var furniture = EntityConnection.HotelFurnitures.Where(x => x.Name.Equals(item.Name)).First();

                if (furniture != null)
                {
                    EntityConnection.HotelFurnitures.Remove(furniture);
                }
            }

            EntityConnection.SaveChanges();
        }
        /// <summary>
        /// Удаляем элементы из БД ур. комфорта
        /// </summary>
        /// <param name="arr">Список ур. комфорта для удаления</param>
        public static void RemoveRange(ICollection<RoomType> arr)
        {
            foreach (var item in arr)
            {
                var room = EntityConnection.RoomTypes.Where(x => x.Level.Equals(item.Level)).First();

                if (room != null)
                {
                    foreach (var number in item.HotelNumbers)
                    {
                        number.Comfortable = null;                        
                    }
                    EntityConnection.RoomTypes.Remove(room);
                }
            }
            EntityConnection.SaveChanges();
        }
        #endregion

        #region Default Value
        /// <summary>
        /// Комната по умолчанию
        /// </summary>
        /// <param name="floor">Этаж</param>
        /// <param name="bed">Номер комнат</param>
        /// <returns></returns>
        public static HotelNumber CreateDefaultNumber(short floor, byte bed = 1)
        {
            HotelNumber number = new HotelNumber
            {
                RoomIndex = 1,
                FloorIndex = floor,
                BedCount = bed,
                IsEmpty = true,
                Price = 100
            };

            // Если есть ур. комфорта по умолчанию, то присваиваем значение, нет создаем
            if (EntityConnection.RoomTypes.Count() > 0)
            {
                number.RoomType = EntityConnection.RoomTypes.First();
                number.Comfortable = number.RoomType.Level;
            }
            else
            {
                number.RoomType = CreateDefaultRoomType();
                number.Comfortable = number.RoomType.Level;
            }
            return number;
        }      
        /// <summary>
        /// Создание ур. комфорта по-умолчанию
        /// </summary>
        /// <returns></returns>
        public static RoomType CreateDefaultRoomType()
        {
            var room = EntityConnection.RoomTypes.Add(new RoomType() { Level = "Стандарт", Description = "Стандартный уровень комфорта", AdditionalServices = "нету" });
            EntityConnection.SaveChanges();
            return room;
        }
        #endregion
        
        #region Contains
        /// <summary>
        /// Проверка на существование
        /// </summary>
        /// <param name="value">Мебель</param>
        /// <returns>true-существует, false-нет</returns>
        public static bool IsContains(HotelFurniture value)
        {
            if (EntityConnection.HotelFurnitures.AsEnumerable().Contains(value))
                return true;

            return false;
        }
        /// <summary>
        /// Проверка на существование
        /// </summary>
        /// <param name="value">Ур.Комфорта</param>
        /// <returns>true-существует, false-нет</returns>
        public static bool IsContains(RoomType value)
        {
            if (EntityConnection.RoomTypes.AsEnumerable().Where(x=>x.Level.Equals(value.Level)).Count()>0)
                return true;

            return false;
        }
        /// <summary>
        /// Проверка на существование
        /// </summary>
        /// <param name="value">Работник отеля</param>
        /// <returns>true-существует, false-нет</returns>
        public static bool IsContains(HotelWorker value)
        {
            if (EntityConnection.HotelWorkers.AsEnumerable().Contains(value))
                return true;

            return false;
        }
        /// <summary>
        /// Проверка на существование
        /// </summary>
        /// <param name="value">Номер отеля</param>
        /// <returns>true-существует, false-нет</returns>
        public static bool IsContains(HotelNumber value)
        {
            if (EntityConnection.HotelNumbers.AsEnumerable().Contains(value))
                return true;

            return false;
        }
        /// <summary>
        /// Проверка на существование
        /// </summary>
        /// <param name="value">Постоялец отеля</param>
        /// <returns>true-существует, false-нет</returns>
        public static bool IsContains(Guest value)
        {
            if (EntityConnection.Guests.AsEnumerable().Contains(value))
                return true;

            return false;
        }
        /// <summary>
        /// Проверка на существование
        /// </summary>
        /// <param name="value">Отель</param>
        /// <returns>true-существует, false-нет</returns>
        public static bool IsContains(HotelInfo value)
        {
            if (EntityConnection.HotelInfoes.Where(x => x.Name.Equals(value.Name)).Count() > 0)
                return true;

            return false;
        }
        #endregion

        #region Additional functions

        /// <summary>
        /// Вспомогательный метод для освобождение номеров
        /// </summary>
        /// <param name="number">Номер который освободить</param>
        /// <returns>Освобожденный номер</returns>
        public static HotelNumber ReleaseNumber(HotelNumber number)
        {
            try
            {
                if (IsContains(number))
                {
                    HotelNumber existingModel = EntityConnection.HotelNumbers.Where(x => x.HotelID == number.HotelID && x.RoomIndex == number.RoomIndex && x.FloorIndex == number.FloorIndex).First();

                    if (existingModel != null)
                    {
                        EntityConnection.Child_Guest.RemoveRange(existingModel.Guest.Child_Guest);
                        EntityConnection.Guests.Remove(existingModel.Guest);
                        existingModel.Guest = null;
                        existingModel.GuestID = null;
                        existingModel.IsEmpty = true; 
                        return existingModel;
                    }
                    else
                    {
                        throw new MyException("HotelWorker.HotelCreator.AddOrUpdateHotelNumber()");
                    }
                }
                return null;
            }
            finally
            {
                EntityConnection.SaveChanges();
            }
        }
        /// <summary>
        /// Получения номера отеля по параметрам
        /// </summary>
        /// <param name="hotelId">Отель</param>
        /// <param name="floor">Этаж</param>
        /// <param name="room">Комната</param>
        /// <returns>Номер отеля</returns>
        public static HotelNumber GetHotelNumber(int hotelId, short floor, short room)
        {
            return EntityConnection.HotelNumbers.Where(x => x.FloorIndex == floor && x.RoomIndex == room && x.HotelID == hotelId).First();
        }  
        
        /// <summary>
        /// Проверка на существование элемента в коллекции
        /// </summary>
        /// <param name="number">Номер</param>
        /// <param name="collection">Список номеров</param>
        /// <returns>Есть ли номер в коллекции номеров</returns>
        private static bool IsExists(HotelNumber number, ICollection<HotelNumber> collection)
        {
            foreach (var item in collection)
            {
                if (item.HotelID == number.HotelID && item.RoomIndex == number.RoomIndex && item.FloorIndex == number.FloorIndex)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Инофрмация об ур.комфорта
        /// </summary>
        /// <returns>Список всех доступных уровней комфорта</returns>
        public static string[] GetComfortData()
        {
            return EntityConnection.RoomTypes.Select(x => x.Level).ToArray();
        }
        /// <summary>
        /// Информация об отеле
        /// </summary>
        /// <returns>Получить список название отелей</returns>
        public static string[] GetHotelData()
        {
            return EntityConnection.HotelInfoes.Select(x => x.Name).ToArray();
        }
        #endregion

        #region Registration
        /// <summary>
        /// Проверка на существования пользователя в БД отеля
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="hotelName">Имя отеля</param>
        /// <returns></returns>
        public static bool IsUserExists(string login, string hotelName)
        {
            if (EntityConnection.HotelWorkers.Where(x => x.Login.Equals(login) && x.HotelInfo.Name.Equals(hotelName)).Count() > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Проверка на правильность ввода пароля и логина пользователя для доступа к данным отеля
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="hotelName">Имя отеля</param>
        /// <returns></returns>
        public static HotelWorker IsUserCorrect(string login, string password, string hotelName)
        {
            return EntityConnection.HotelWorkers.Where(x => x.Login.Equals(login) && x.Password.Equals(password) && x.HotelInfo.Name.Equals(hotelName)).First();
        }
        #endregion

        #region GET INFO
        public static DbSet<HotelFurniture> GetHotelFurnitures()
        {            
            return EntityConnection.HotelFurnitures;
        }
        public static DbSet<RoomType> GetRoomTypes()
        {
            return EntityConnection.RoomTypes;
        }
        #endregion
    }
}
