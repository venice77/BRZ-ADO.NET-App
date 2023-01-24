using System;
using System.Collections.Generic;


using BiuroRzeczyZnalezionych.Models;

namespace BiuroRzeczyZnalezionych
{
    public class PrzedmiotManager
    {
        public PrzedmiotManager AddItem(PrzedmiotModel przedmiot)
        {
            using (var db = new PrzedmiotContext())
            {
                db.Add(przedmiot);
                db.SaveChanges();
            }
            return this;
        }
        public PrzedmiotManager UpdateItem(PrzedmiotModel editedEntity)
        {
            using (var db = new PrzedmiotContext())
            {
                var przedmiot = db.Przedmioty.Where(b => b.ID == editedEntity.ID).FirstOrDefault();
                przedmiot.Nazwa = editedEntity.Nazwa;
                przedmiot.dataDodania = editedEntity.dataDodania;
                przedmiot.dataZwrotu = editedEntity.dataZwrotu;
                db.SaveChanges();
            }
            return this;
        }
        public PrzedmiotManager DeleteItemById(int id)
        {
            using (var db = new PrzedmiotContext())
            {
                var przedmiot = db.Przedmioty.Where(b => b.ID == id).FirstOrDefault();
                db.Przedmioty.Remove(przedmiot);
                db.SaveChanges();
            }
            return this;
        }
        public PrzedmiotManager ReturnItem(int id)
        {
            using (var db = new PrzedmiotContext())
            {
                var przedmiot = db.Przedmioty.Where(b => b.ID == id).FirstOrDefault();
                przedmiot.dataZwrotu = DateTime.Now;
                db.SaveChanges();
            }
            return this;
            
        }
        public PrzedmiotModel GetItemById(int id)
        {
            using (var db = new PrzedmiotContext())
            {
                var przedmiot = db.Przedmioty.Where(b => b.ID == id).FirstOrDefault();
                return przedmiot;
            }
            return null;
        }
        public List<PrzedmiotModel> GetAllItems()
        {
            using (var db = new PrzedmiotContext())
            {
                var przedmiot = db.Przedmioty.Where(b => b.dataZwrotu == DateTime.MinValue).OrderByDescending(b=>b.dataDodania);
                var returnedPrzedmiot = db.Przedmioty.Where(b => b.dataZwrotu != DateTime.MinValue).OrderByDescending(b => b.dataDodania);
                var orderedList = przedmiot.ToList();
                orderedList.AddRange(returnedPrzedmiot.ToList());
                return orderedList;
            }
        }
    }
}
