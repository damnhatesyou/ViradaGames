using System.Globalization;

namespace ViradaGames
{
    class Game : Item
    {
        private string publisher;
        private string mediaType;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public string MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }

    }
}