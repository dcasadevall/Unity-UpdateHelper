# Unity-UpdateHelper

This simple system can be used to help you avoid using Monobehaviours in Unity whenever you don't need one.
Most of the times, Monobehaviours are used simply for their update loop.

Implementors of the IUpdateHelper interface can provide a common update loop that can be shared accross several objects implementing IUpdateDelegate. 
A common update loop as opposed to several smaller objects containing update loops will result in an increased performance in your project.

Additionally, your code will be more testable, as you will no longer have a Monobehaviour dependency where there previously was one.

# Usage

  - Create an implementation of IUpdateHelper. You can use the UpdateHelperMonobehaviour as a starting point. This implementation needs to be placed in your scene. It uses its update loop to call IUpdateDelegate.Update() on an internal list of delegates.
  - Provide your IUpdateHelper throughout the code, using any means of Dependency Injection.
  - Classes interested in having an update loop provided, can call IUpdateHelper.RegisterDelegate(this) on construction.
  - Classes using the update helper should call IUpdateHelper.UnregisterDelegate(this) when they are disposed (if following the IDisposable pattern) or no longer used.

License
----

The MIT License (MIT)
=====================

Copyright © `2018` `Daniel Casadevall Pino`

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the “Software”), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
