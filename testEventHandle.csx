class Counter
{
    public event EventHandler ThresholdReached;

    protected virtual void OnThresholdReached(EventArgs e)
    {
        EventHandler handler = ThresholdReached;
        if (handler != null)
        {
            handler(this, e);
        }
    }

    // provide remaining implementation for the class
}

static void c_ThresholdReached(object sender, EventArgs e)
{
    Console.WriteLine("The threshold was reached.");
}

Counter c = new Counter();
c.ThresholdReached += c_ThresholdReached;
Console.ReadLine();
// provide remaining implementation for the class