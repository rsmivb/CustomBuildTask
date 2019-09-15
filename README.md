# CustomBuildTask

### Features

- Repository contains Build Custom Tasks application and an application consuming the custom task have been built as .NET Framework 4.8.
- Generate a nuget package for the custom task - find on BuildCustomTask\BuildCustomTask.1.0.0.nupkg;
- Add it on your project and add this code on your csproj:
````
<!-- Using a custom task-->
  <UsingTask TaskName="MyCustomBuildTask" AssemblyFile="..\packages\BuildCustomTask.1.0.0\lib\net48\BuildCustomTask.dll">
  </UsingTask>
  <Target Name="MyTasks" AfterTargets="AfterBuild">
    <MyCustomBuildTask Value="$(AssemblyName)" CsProjPath="$(AssemblyName).csproj" CsProjItemType="None" />
  </Target>
````
|Build your application using Custom task and the output should be something like this:
````
MyTasks:
  Hi, I'm running a custom build task -> ConsoleAppUsingCustomTask
  Reading values from None
  Item -> EvaluatedInclude: App.config, UnevaluadedInclude: App.config
  Item -> EvaluatedInclude: packages.config, UnevaluadedInclude: packages.config
Done Building Project "C:\workspace\CustomBuildTask\ConsoleAppUsingCustomTask\ConsoleAppUsingCustomTask.csproj" (defaul
t targets).
````


### TO DO

- Build a Custom task for netcore and .Net Framework and publish as nuget package

### Links

[Understand MSBuild](https://chimpiq.com/msbuild-part-1/)

[Example to create Custom Build Task](https://natemcmaster.com/blog/2017/07/05/msbuild-task-in-nuget/)

[Unit test for Custom Build Task](https://stackoverflow.com/questions/260847/unit-test-msbuild-custom-task-without-task-attempted-to-log-before-it-was-initi)

[Create and Publish a Nuget Package](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework)

[Nuget Package Explorer](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer)
