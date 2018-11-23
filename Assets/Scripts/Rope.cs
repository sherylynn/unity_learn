using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour {

	// 使用 Rope Segment 预设
	public GameObject ropeSegmentPrefab;

	List<GameObject> ropeSegments =new List<GameObject>();

	public bool isIncreasing {get; set;}
	public bool isDecreasing {get; set;}
	public Rigidbody2D connectedObject;
	public float maxRopeSegmentLength = 1.0f;
	public float ropeSpeed =4.0f;
	LineRenderer lineRenderer;
	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer>();
		ResetLength();
	}
	public void ResetLength(){
		foreach (GameObject segment in ropeSegments ){
			Destory(segment);
		}
		ropeSegments =new List<GameObject>();
		isDecreasing=false;
		isIncreasing=false;
		CreateRopeSegment();
	}
	void CreateRopeSegment(){
		GameObject segment =(GameObject)Instantiate(
			ropeSegmentPrefab,
			this.transform.position,
			Quaternion.identity);
		segment.transform.SetParent(this.transform,true);
		Rigidbody2D segmentBody = segment.GetComponent<Rigidbody2D>();
		SpringJoint2D segmentJoint=segment.GetComponent<SpringJoint2D>();
	}


  // Update is called once per frame
  void Update () {
		
	}
}
