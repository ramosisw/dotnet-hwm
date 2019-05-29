# dotnet-hwm
[![Build Status](https://dev.azure.com/ramosisw/dotnet-hwm/_apis/build/status/ramosisw.dotnet-hwm?branchName=master)](https://dev.azure.com/ramosisw/dotnet-hwm/_build/latest?definitionId=5&branchName=master) [![Docker-Images](https://img.shields.io/docker/pulls/ramosisw/dotnet-hwm.svg)](https://hub.docker.com/r/ramosisw/dotnet-hwm)

A dotnet hello world multi-arch docker container

The intention of this repository is to have a reference to be able to compile multi-architecture images.
Using Azure DevOps, the .Net Core application that writes the console "Hello World from {arch} CPU" was compiled.

# Run docker image on amd64/arm arch
```sh
docker run ramosisw/dotnet-hwm
```

## Output on Linux x64
```sh
docker run ramosisw/dotnet-hwm
Hello World from X64 CPU
```

## Output on Raspberry Pi 3 B+
```sh
docker run ramosisw/dotnet-hwm
Hello World from Arm CPU
```


# Deploy Trigger
Only deploy to docker if the commit message starts with `[Deploy]`
