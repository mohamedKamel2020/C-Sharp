
public class Player {
    private float score;
    private static int noOfWinners = 0;

    public Player(float s) {
        score = s;
        if (score > 3000) {
            noOfWinners++;
        }
    }

    public void setScore(float s) {
        if (s > 3000 && score < 3000) {
            noOfWinners++;
        }
        score = s;
    }

    public float getScore() {
        return score;
    }

    public static int getNoOfWinners() {
        return noOfWinners;
    }

    public void IncrementScore(float added) {
        if (score < 3000 && score + added > 3000) {
            noOfWinners++;
        }
        score = score + added;
    }

    public void DecrementScore(float dec) {
        if (score > 3000 && score - dec < 3000) {
            noOfWinners--;
        }
        score = score - dec;
    }

    public String toString() {
        return "Score : " + score;
    }

    public boolean equals(Player p) {
        return (score == p.score);
    }

}
