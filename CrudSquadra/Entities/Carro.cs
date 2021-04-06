using System.ComponentModel.DataAnnotations;


namespace CrudSquadra.Entities
{
    public class Carro
    {
        [Key]
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

    }

}
