1. ### Method 1
    a. Using prepocessor directive platform in custom control definition <br/>
    b. Custom control is called in <code>MauiProgram</code><br/>

2. ### Method 2
    a. Using prepocessor directive platform in custom control definition<br/>
    b. Custom control is called in <code>App</code> constructor<br/>

3. ### Method 3
    a. Using (or can be not use) prepocessor directive platform in custom control definition<br/>
    b. Custom control is called in platform specific starter. In IOS example in <code>AppDelegate</code><br/>

4. ### Method 4
    a. Using partial class in Shared and Platform Specific for custom control definition.<br/>
    b. Need not platform prepocessor directive in custom control definition. Since the definition inside folder platform specific<br/>
    b. Custom control is called in <code>MauiProgram</code><br/>