coverlet tests/App.Api.UnitTest/bin/Debug/net6.0/App.Api.UnitTest.dll --target "dotnet" --targetargs "test /tests/App.Api.UnitTest --no-build"
coverlet tests/App.Application.UnitTest/bin/Debug/net6.0/App.Application.UnitTest.dll --target "dotnet" --targetargs "test /tests/App.Application.UnitTest --no-build" --merge-with "coverage.json"
coverlet tests/App.Infrastructure.UnitTest/bin/Debug/net6.0/App.Infrastructure.UnitTest.dll --target "dotnet" --targetargs "test /tests/App.Infrastructure.UnitTest --no-build" --merge-with "coverage.json"
coverlet tests/App.Domain.UnitTest/bin/Debug/net6.0/App.Domain.UnitTest.dll --target "dotnet" --targetargs "test /tests/App.Domain.UnitTest --no-build" --merge-with "coverage.json" --format cobertura
reportgenerator -reports:coverage.cobertura.xml -targetdir:docs/_site/coveragereport -reportTypes:html