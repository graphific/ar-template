# AR Foundation & Extensions Template

Reusable Template setup using 
- [AR Foundation 6.0](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@6.0/manual/index.html), 
- [AR Foundation 6.0 Samples](https://github.com/Unity-Technologies/arfoundation-samples) (see [readme](README.Arf.md)),
- [Google Extensions](https://github.com/graphific/arcore-unity-extensions) for geospatial support (localization against streetscape geometries, visualizing street geometries, and scene semantics),
- Scene Semantics (segmentation) adapted [demo-megagolf](https://github.com/google-ar/demo-megagolf)
- modded to support [AR Foundation Replay](https://github.com/asus4/ARFoundationReplay) for basic AR and geospatial functionality

## Replay
- Recording Replay videos only on Android (ARCore) atm
   - 2 example replay videos at [WorldEnsemble](https://github.com/asus4/WorldEnsemble) 
- Replay itself only for macOS Editor for now. :)
- Tested with the latest Unity2023.3.0b8
- Supported only URP.

## Implemented Subsystems 
(details in https://github.com/asus4/ARFoundationReplay/tree/main)

- [x] XRSessionSubsystem
- [x] XRCameraSubsystem
- [ ] XRPointCloudSubsystem
- [x] XRPlaneSubsystem
- [ ] XRAnchorSubsystem
- [ ] XRRaycastSubsystem
- [ ] XRHumanBodySubsystem
- [ ] XREnvironmentProbeSubsystem
- [x] XRInputSubsystem
- [ ] XRImageTrackingSubsystem
- [ ] XRObjectTrackingSubsystem
- [ ] XRFaceSubsystem
- [x] XROcclusionSubsystem
- [ ] XRParticipantSubsystem
- [ ] XRMeshSubsystem
- ARCore Extensions
  - [x] Earth Manager
  - [ ] Cloud Anchors
  - [x] Streetscape Geometry
