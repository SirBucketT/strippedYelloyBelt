namespace Kata2;

public class Character
{
    public string Name {get;}
    public int Health { get; set; }

    public Action<List<Character>> CharacterAction { get; }
    public event Action<int> HealthChanged;
    
    public Character(string name, int health, Action<List<Character>> characterAction)
    {
        Name = name;
        Health = health;
        CharacterAction = characterAction;
    }

    public void TakeDamage(int damage, int health)
    {
        Health -= damage;
        HealthChanged?.Invoke(health);
    }
}