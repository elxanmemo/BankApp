namespace bank.DTOs.UserDto
{
    public record UserToAddDto
    {
        public string Fin { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
