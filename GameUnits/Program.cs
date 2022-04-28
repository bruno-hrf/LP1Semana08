namespace GameUnits
{
    public class Program
    {
        private static void Main(string[] args)
        {

            List<Unit> myUnits = new List<Unit>();


            foreach(Unit u in myUnits)
            {
                u.Move(new Vector2(10,5));
            }


        }
    }
}

