namespace FragranceStore__L00183767.Models.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string imageURL { get; set; }


        //Foreign Keys
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int ConcentrationId { get; set; }
        public Concentration Concentration { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public int SizeId { get; set; }
        public Size Size { get; set; }

    }

}
        
