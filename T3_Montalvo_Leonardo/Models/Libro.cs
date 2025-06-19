using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T3_Montalvo_Leonardo.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Título es Obligatorio.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El Autor es Obligatorio.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El Tema es Obligatorio.")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "La Editorial es Obligatoria.")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El Año de Publicación es Obligatorio.")]
        [Range(1900, 3000, ErrorMessage = "El Año de Publicación debe ser entre 1900 y 3000")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "La Cantidad de Paginas es Obligatoria.")]
        [Range(10, 1000, ErrorMessage = "La Cantidad de Paginas deber ser entre 10 y 1000")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "La Categoria es Obligatoria.")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El Material es Obligatorio.")]
        public string Material { get; set; }

        [Required(ErrorMessage = "La Cantidad de Copias es Obligatoria.")]
        [Range(1, 20, ErrorMessage = "La Cantidad de Copias debe ser entre 1 y 20")]
        public int Copias { get; set; }
    }
}
