namespace exercise_131
{
    public class Item
    {

        private string identifier;
        private string name;

        public Item(string identifier, string name)
        {
            this.identifier = identifier;
            this.name = name;
        }
        public override string ToString()
        {
            return this.identifier + ": " + this.name;
        }

        public override bool Equals(object compared)
        {

            //compare with Item.identifier
            if (this.GetHashCode() == compared.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            string hash = this.identifier;
            return hash.GetHashCode();
        }
    }

}