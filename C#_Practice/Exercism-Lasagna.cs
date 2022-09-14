class Lasagna
{
    Lasagna lasagna = new Lasagna();
    
    public int ExpectedMinutesInOven() {
        return 40;
    }

    public int RemainingMinutesInOven (int cookedTime) {
        int timeToCook = 40;
        int timeLeftToCook = timeToCook - cookedTime;
        return timeLeftToCook;
    }


    public int PreparationTimeInMinutes (int layers) {
        int totalPreparationTime = layers * 2;
        return totalPreparationTime;
    }

    public int ElapsedTimeInMinutes (int layers, int beenInOven) {
        int prepTime = layers * 2;
        int timeWorkedOn = prepTime + beenInOven;
        return timeWorkedOn;
    }
}
