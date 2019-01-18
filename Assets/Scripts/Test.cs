using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Test : SerializedMonoBehaviour {

    public ITest TestField;
    
    public interface ITest {}

    public class SomeImplementation : ITest {
        public int Integer;
        public GameObject Go;
    }
}
