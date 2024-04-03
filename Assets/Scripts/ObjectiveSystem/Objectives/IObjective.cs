// Interface for the objective class itself

public interface IObjective
{
    bool isCompleted { get; set; }
    string Name { get; set; }
    PlayerController playerController {get; set; }

    void Complete();

}
