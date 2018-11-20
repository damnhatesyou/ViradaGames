namespace ViradaGames
{
    class Accessory : Item
    {
        private string modelType;

        public string ModelNumber
        {
            get { return modelType; }
            set { modelType = value; }
        }
    }
}