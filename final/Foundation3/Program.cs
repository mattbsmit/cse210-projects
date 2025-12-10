using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("Speeding Speedster Drive", "Charleston", "AK", "USA");
        Address addressTwo = new Address("Hugging Juggler Way", "Boston", "CA", "Turkey");
        Address addressThree = new Address("Free Bird Boulevard", "Renee", "FL", "Japan");


        Lecture lecture = new Lecture(
            "Lecture",
            "How To Avoid Fines While Carrying Uranium",
            "This lecture presented by Dr. Amy Johnson teaches us how to avoid fines when carrying uranium in public settings",
            "14 DEC 2234",
            "4:30pm",
            addressOne,
            "Dr. Amy Johnson",
            120
        );

        Outdoor outdoor= new Outdoor(
            "Outdoor",
            "July Christmas Ball",
            "Come celebrate Christmas in July with our new annual ball this weekend!",
            "21 JUL 2026",
            "5pm",
            addressTwo,
            "Full Sun, 82F"
        );

        Reception reception= new Reception(
            "Reception",
            "Wedding Reception for Anakin & Padame",
            "Your invited to attend the wedding for the lovely couple of Anakin & Padame",
            "23 FEB 21 BBY",
            "3pm",
            addressThree,
            "Obi Wan",
            "kenobithemaster66@jedimaster.com"
        );

        lecture.ShortDescription();
        outdoor.FullDetails();
        reception.StandardDetails();
    }
}