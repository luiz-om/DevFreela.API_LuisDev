namespace DevFreela.API.Entities;

public class UserSkill
{
    public UserSkill(int iduser, int idskill)
    : base()
    {
        IdUser = iduser;
        IdSkill = idskill;
    }
    public int IdUser { get; private set; }
    public User User { get; private set; }
    public int IdSkill { get; private set; }
    public Skill Skill { get; private set; }
    
}