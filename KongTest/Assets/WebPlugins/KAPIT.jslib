mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
  },

  StartKong: function()
  {
	  if(typeof(kongregateUnitySupport) != 'undefined'){
        kongregateUnitySupport.initAPI('KongregateAPI', 'OnKongregateAPILoaded');
	  }
  },
  
  SubmitKStat: function(statName , amount)
  {
	 kongregate.stats.submit(statName,amount);
  },
});