
run: build-blueprints
	dotnet run
.PHONY: run

clean:
	dotnet clean
	rm -r ./build
	rm -r ./bin
	rm -r ./obj
.PHONY: clean 

build-blueprints:
	# This compiles the blueprint files into gtk ui files in a directory called ui
	blueprint-compiler batch-compile build/ blueprints blueprints/**.blp
.PHONY: build-blueprints

build: build-blueprints
	dotnet build
.PHONY: build
