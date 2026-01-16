class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int MinutesInOven) => ExpectedMinutesInOven() - MinutesInOven;

    public int PreparationTimeInMinutes(int camada) => camada * 2;

    public int ElapsedTimeInMinutes(int camada, int MinutesInOven) => camada * 2 + MinutesInOven;
}
