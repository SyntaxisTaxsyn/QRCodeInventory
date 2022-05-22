public class QRCodeIVM
{
    public int Id {get;set;}
    public string? QRCode {get;set;}
    public string? DeviceName {get;set;}
    public bool status {get;set;}
    public int UserId {get;set;}

}

public class User
{
    public int UserId {get;set;}
    public string? Username {get;set;}
    public string? Password {get;set;}

}