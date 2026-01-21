class Unit
{
    private float _health;
    public float Health => _health;
    public string Name {get;}
    public int Damage {get;}
    public float Armor {get;}

    public Unit(string name) 
    {
    Name = name;
    Damage = 5;
    Armor = 0.6f;
    _health = 10f;
    }
    public Unit() : this("Unknown Unit"){}

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