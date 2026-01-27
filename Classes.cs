using System;
class Unit
{
    private float _health;
    public float Health => _health;
    public string Name {get;}
    public Interval Damage {get;}
    public float Armor {get;}

    public Unit(string name) 
    {
    Name = name;
    Damage = 5;
    Armor = 0.6f;
    _health = 10f;
    }
    public Unit() : this("Unknown Unit"){}

    public Unit(string name, int minDamage, int maxDamage)
    {
        Name = name;
        Damage = new Interval(minDamage, maxDamage);
    }


    public float GetRealHealth()
    {
      return _health * (1f + Armor);
    }
    
    public bool SetDamage(float damage)
    {
     _health -= damage * Armor;
     return _health <= 0;
    }
}

class Weapon
{
  public string Name {get;}
  public Interval Damage;
  public float Durability {get;}

  public Weapon(string name)
  {
    Name = name;
  }

  public Weapon(string name, Interval damage) : this (name)
  {
    SetDamageParams(damage);
    Durability = 1f;
  } 

  public void SetDamageParams(Interval damage)
  {
    if(damage.Min > damage.Max)
    {
      (damage.Min, damage.Max) = (damage.Max, damage.Min);
      Console.WriteLine($"Input data for {Name} is not correct.");
    }

    if(damage.Min < 1)
    {
      damage.Min = 1;
      Console.WriteLine("Forced setting of the minimal value.");
    }
    
    if(damage.Max <= 1)
    {
      damage.Max = 10;
    }

    Damage = damage;
  }

  public float GetDamage()
  {
    return meanValue = (damage.Max + damage.Min) / 2;
  }
}


struct Interval
{
  public int Min;
  public int Max;
  private readonly Random _random = new Random();

  public int Get()
  {
    return _random.Next(Min,Max+1);
  }

  public Interval(int minValue, int maxValue)
  {
    if(minValue > maxValue)
    {
      (minValue, maxValue) = (maxValue, minValue);
      Console.WriteLine("Input data is not correct.");
    }

    if(minValue < 0)
    {
      minValue = 0;
      Console.WriteLine("Input data is not correct.");
    }

    if(maxValue < 0)
    {
      maxValue = 0;
      Console.WriteLine("Input data is not correct.");
    }

    if(maxValue = minValue)
    {
      maxValue += 10;
      Console.WriteLine("Input data is not correct.");
    }
       
  }
}

struct Room
{
  private Unit Unit;
  private Weapon Weapon;

  public Room(Unit unit, Weapon weapon)
  {
    Unit = unit;
    Weapon = weapon;
  }
}

class Dungeon
{
  private Room[] rooms;

  public Dungeon()
  {
    rooms = new Room[]
    {
      
      new Room(
          new Unit("Johnny Cage"),
          new Weapon("Spoon")
      ),

      new Room(
          new Unit("Sonya"),
          new Weapon("Fork")
      ),

      new Room(
          new Unit("Kitana"),
          new Weapon("Knife")
      ),

      new Room(
          new Unit("Mileena"),
          new Weapon("Chopsticks")
      )
    };
    }

    public void ShowRooms()
    {
      for(int i = 0; i < rooms.Length; i++) 
      {
      var room = rooms[i];
      Console.WriteLine("Unit of room" + room.Unit);
      Console.WriteLine("Weapon of room" + room.Weapon);
      Console.WriteLine("—");
      }
    }

    public void Main(string[] args)
  {
    Dungeon dungeon= new Dungeon();
    dungeon.ShowRooms();
  }
  }

}
