namespace Audio.Managment;
    public class AudioManager
    {
        public const int Volume = 2;

        private readonly float Pitch;

        public AudioManager()
        {
            Pitch = 2.5f;
        }

        public void PlaySound(int vol = Volume, float p = 0.5f)
        {
            Console.WriteLine("vol =  " + vol + " pitch = " + p);
        }
    }