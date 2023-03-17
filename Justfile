run: build-blueprints
    dotnet run
    
clean:
    dotnet clean
    rm -r ./build
    rm -r ./bin
    rm -r ./obj

build-blueprints:
    # This compiles the blueprint files into gtk ui files in a directory called ui
    blueprint-compiler batch-compile build/ blueprints blueprints/**.blp

build: build-blueprints
    dotnet build

