public static class GpaCalculator
{
    public static decimal ToGpa(decimal marks)
    {
        if (marks >= 80) return 4.0m;
        if (marks >= 70) return 3.5m;
        if (marks >= 60) return 3.0m;
        if (marks >= 50) return 2.5m;
        if (marks >= 40) return 2.0m;
        return 0.0m;
    }
}
