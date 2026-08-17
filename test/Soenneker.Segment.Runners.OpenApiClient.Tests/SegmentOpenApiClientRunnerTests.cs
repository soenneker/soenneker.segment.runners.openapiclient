using Soenneker.Tests.HostedUnit;

namespace Soenneker.Segment.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SegmentOpenApiClientRunnerTests : HostedUnitTest
{
    public SegmentOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
