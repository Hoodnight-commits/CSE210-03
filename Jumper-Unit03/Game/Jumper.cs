// This class that contains the jumper layout
namespace Jumper_Unit04
{
    public class Jumper
    {
        public Jumper() {}

        public List<string> Parachute()
        {
            var items = new List<string> { "  ____", " /____\\", " \\    /", "  \\  /", "    O", "   /|\\", "   / \\" };

            return items;
        }
        public int GetCount() 
        {
        return this.Parachute().Count;
        }

        // This method draws the jumper
        public void DrawJumper(List<string> layout)
        {
            List<string> items = Parachute();

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}