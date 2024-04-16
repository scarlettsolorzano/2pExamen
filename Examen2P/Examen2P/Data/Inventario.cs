using System.ComponentModel.DataAnnotations;

namespace Examen2P.Data
{
    public class Inventario
    {
        [Required(ErrorMessage = "Debe ser un número entero positivo mayor a 0")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un entero positivo.")]
        public int NoInventario { get; set; }

        [Required(ErrorMessage = "El nombre no debe estar vacío")]
        [StringLength(200, ErrorMessage = "Excede el máximo de caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el departamento")]
        public string Departamento { get; set; }
    }
}
