namespace Woorj.Data.Adm
{
    public class RoleAccessRight
    {
    public string ApplicationRoleId { get; set; }
    public ApplicationRole ApplicationRole { get; set; }    

    public int AccessRightId { get; set; }
    public AccessRight AccessRight { get; set; }
        
    }
}