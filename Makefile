.PHONY: restore build test

restore:
	dotnet restore TargetLibrary

build:
	dotnet build TargetLibrary

test:
	dotnet test TargetLibrary.Tests
