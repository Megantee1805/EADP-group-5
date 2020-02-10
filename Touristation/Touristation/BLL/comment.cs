namespace Touristation.DAL
{
    public class comment
    {
        internal object userid;
        private string id;
        private string loca;
        private int rate;
        private string com;

        public comment(string id, string loca, int rate, string com, int userid)
        {
            this.id = id;
            this.loca = loca;
            this.rate = rate;
            this.com = com;
        }

        public object Id { get; internal set; }
        public object Loca { get; internal set; }
        public object Rate { get; internal set; }
        public object Com { get; internal set; }
    }
}