﻿namespace WebApp_MVC_Project.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public String Ad { get; set; }
        public int Kredisi { get; set; }
        public String OkulYonetimId { get; set; }  // Öğretim görevlisi

    }
}
