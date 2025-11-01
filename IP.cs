public class IP
{
    private int[] segments = new int[4];

    // Indexer for accessing or modifying IP segments
    public int this[int index]
    {
        get => segments[index];
        set
        {
            if (!IsValidSegment(value))
                throw new ArgumentOutOfRangeException($"Segment value {value} is invalid. Must be between 0 and 255.");
            segments[index] = value;
        }
    }

    // Property to get the full address
    public string Address => string.Join(".", segments);

    // Constructors
    public IP(string ipAddress)
    {
        var parts = ipAddress.Split('.');
        if (parts.Length != 4)
            throw new ArgumentException("Invalid IP format. Must contain 4 segments.");

        for (int i = 0; i < 4; i++)
        {
            int value = int.Parse(parts[i]);
            if (!IsValidSegment(value))
                throw new ArgumentOutOfRangeException($"Segment {value} is invalid. Must be between 0 and 255.");
            segments[i] = value;
        }
    }

    public IP(int s1, int s2, int s3, int s4)
    {
        int[] vals = { s1, s2, s3, s4 };
        for (int i = 0; i < 4; i++)
        {
            if (!IsValidSegment(vals[i]))
                throw new ArgumentOutOfRangeException($"Segment {vals[i]} is invalid. Must be between 0 and 255.");
            segments[i] = vals[i];
        }
    }

    // ✅ Helper method for validation
    private bool IsValidSegment(int value) => value >= 0 && value <= 255;

    // ✅ Override ToString for easy printing
    public override string ToString() => Address;
}
