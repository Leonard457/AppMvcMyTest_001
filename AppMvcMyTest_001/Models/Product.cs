using System.ComponentModel.DataAnnotations; // Исправлено: добавлено "using" и ";" для корректного импорта пространства имен

namespace AppMvcMyTest_001.Models
{
    public class Product
    {
        public int Id { get; set; } // Первичный ключ (по соглашению)
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Исправлено: атрибуты валидации должны быть применены к свойствам
        //[Required]
        //[StringLength(100)]
    }
}
