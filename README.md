
# react-native-bicycle-extreme-performance

## Getting started

`$ npm install react-native-bicycle-extreme-performance --save`

### Mostly automatic installation

`$ react-native link react-native-bicycle-extreme-performance`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-bicycle-extreme-performance` and add `RNBicycleExtremePerformance.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBicycleExtremePerformance.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBicycleExtremePerformancePackage;` to the imports at the top of the file
  - Add `new RNBicycleExtremePerformancePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-bicycle-extreme-performance'
  	project(':react-native-bicycle-extreme-performance').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-bicycle-extreme-performance/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-bicycle-extreme-performance')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBicycleExtremePerformance.sln` in `node_modules/react-native-bicycle-extreme-performance/windows/RNBicycleExtremePerformance.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Bicycle.Extreme.Performance.RNBicycleExtremePerformance;` to the usings at the top of the file
  - Add `new RNBicycleExtremePerformancePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBicycleExtremePerformance from 'react-native-bicycle-extreme-performance';

// TODO: What to do with the module?
RNBicycleExtremePerformance;
```
  