namespace ISP.Exercise;

// Has the data announcements and attendance need, but their signatures do not accept it.
public interface IAuditor
{
    Guid Id { get; }
    string FullName { get; }
    string Email { get; }
}
