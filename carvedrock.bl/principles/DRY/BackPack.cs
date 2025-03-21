namespace carvedrock.bl.principles.DRY
{
	public class BackPack
	{
		public string Name { get; } = null!;
		public double Price { get; set; }
		public int Capacity { get; }
		public double Weight { get; }
		public bool IsWaterproof { get; }

		public BackPack(string name, double price, int capacity, double weight, bool isWaterproof)
		{
			Name = name;
			Price = price;
			Capacity = capacity;
			Weight = weight;
			IsWaterproof = isWaterproof;
		}

		
	}
}