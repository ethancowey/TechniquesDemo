using System;

// Concrete implementation of IService
public class OperationService : IService
{
    private Guid _operationId;

    public OperationService()
    {
        // Each instance gets a unique ID
        _operationId = Guid.NewGuid();
    }

    public Guid GetOperationId() => _operationId;
}