// This class depends on ILogger, not a specific implementation
public class ReportGenerator
{
    private readonly ILogger _logger;

    // Dependency is injected via constructor
    public ReportGenerator(ILogger logger)
    {
        _logger = logger;
    }

    public void Generate()
    {
        _logger.Log("Generating report...");
        // Simulate report logic
        _logger.Log("Report generated successfully.");
    }
}