
# react-native-rn-key-events

## Getting started

`$ npm install react-native-rn-key-events --save`

### Mostly automatic installation

`$ react-native link react-native-rn-key-events`

### Manual installation


#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNRnKeyEvents.sln` in `node_modules/react-native-rn-key-events/windows/RNRnKeyEvents.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Rn.Key.Events.RNRnKeyEvents;` to the usings at the top of the file
  - Add `new RNRnKeyEventsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNRnKeyEvents from 'react-native-rn-key-events';

// TODO: What to do with the module?
RNRnKeyEvents;
```
  