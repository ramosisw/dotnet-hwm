docker manifest create ramosisw/dotnet-hwm ramosisw/dotnet-hwm:amd64 ramosisw/dotnet-hwm:arm
docker manifest annotate --arch arm ramosisw/dotnet-hwm ramosisw/dotnet-hwm:arm
docker manifest push ramosisw/dotnet-hwm