using System.Collections.Generic;

public class ThingController
{
    private List<Thing> _equipment = new List<Thing>();
    
    public void AddThingToEquipment(Thing thing)
    {
        _equipment.Add(thing);
    }

    public Thing FindThingInEquipment(Thing thing)
    {
        return _equipment.Find(thingThatYouLookingFor => thingThatYouLookingFor.name == thing.name);
    }
    
    public List<Thing> GetEquipment()
    {
        return _equipment;
    }
}