class Program
{
    static void Main()
    {
        //Console.WriteLine("Bonjour tout le monde");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.343;

        mercury.DisplayPlanetInformation();

        Planet venus = new Planet();
        venus._name = "Mercury";
        venus._diameter = 12353.234;

        venus.DisplayPlanetInformation();

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venus);
        solarSystem._DisplaySolarSystem();
    }
}