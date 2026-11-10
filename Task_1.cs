using System;

TrafficLight trafficLight=new();
trafficLight.NextColor();
Console.WriteLine(trafficLight.GetColor());
trafficLight.NextColor();
Console.WriteLine(trafficLight.GetColor());
trafficLight.NextColor();
Console.WriteLine(trafficLight.GetColor());
trafficLight.NextColor();
Console.WriteLine(trafficLight.GetColor());

TrafficLight trafficLight2=new();
Console.WriteLine(trafficLight2.GetColor()); 

public class TrafficLight
{
    //fields
    public string Color="Red";

    //methods
    public void NextColor()
    {
        if(this.Color=="Red")
        {
            this.Color="Green";
        }
        else if (this.Color=="Green")
        {
            this.Color="Yellow";
        }
        else if (this.Color=="Yellow")
        {
            this.Color="Red";
        }
    }

    public string GetColor()
    {
        return this.Color;
    }
}