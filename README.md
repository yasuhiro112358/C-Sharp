# C-Sharp

## Create new project
```bash
# Create new project
dotnet new console -n HelloWorldApp

# Create .gitignore
cd HelloWorldApp
dotnet new gitignore
```

## Run the project
```bash
cd HelloWorldApp

# .dllを作成して実行
dotnet run
```

## .NET CLI Command
```bash
# Create new project
# dotnet new <TEMPLATE> -n <PROJECT_NAME>
dotnet new console -n HelloWorldApp

# Compile the project
dotnet build

# Run the project
dotnet run

# Check the version and information
dotnet --version
dotnet --info
```

## Note
- bin/とobj/はビルド時に生成されるディレクトリのため、git管理しない
- .gitignoreを作成できるコマンドがある
- C-Sharp.slnはVisual Studioのソリューションファイル。複数のプロジェクトを管理するためのファイル => git管理する
