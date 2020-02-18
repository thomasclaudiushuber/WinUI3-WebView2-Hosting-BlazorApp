var interopFunctions = {};

interopFunctions.registerIndexComponent = (dotnetObj) => {
  interopFunctions.indexComponent = dotnetObj;
};

interopFunctions.setFirstName = (firstName) => {
  console.log("JavaScript setFirstName executed");

  interopFunctions.indexComponent.invokeMethodAsync('SetFirstName', firstName);
};