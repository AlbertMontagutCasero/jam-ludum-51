using System;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure
{
    public class MusicView: MonoBehaviour
    {
        public AudioSource baseAudioSource;
        public AudioClip baseMusic;
        public AudioClip racoonMusic1;
        public AudioClip racoonMusic2;

        private void Awake()
        {
            GameSignals.OnGameplayStarts += OnGameplayStarts;
            GameSignals.OnGameplayFinishes += OnGameplayFinishes;
            GameSignals.OnRacoonCaught += OnRacoonCaught;
        }

        private void Start()
        {
            this.StopAllMusics();
        }

        private void OnRacoonCaught()
        {
            if (this.baseAudioSource.clip == this.baseMusic)
            {
                var time = this.baseAudioSource.time;
                this.baseAudioSource.clip = this.racoonMusic1;
                this.baseAudioSource.time = time;
                this.baseAudioSource.Play();
                return;
            }

            if (this.baseAudioSource.clip == this.racoonMusic1)
            {
                var time = this.baseAudioSource.time;
                this.baseAudioSource.clip = this.racoonMusic2;
                this.baseAudioSource.time = time;
                this.baseAudioSource.Play();
            }
        }

        private void OnGameplayFinishes(GameDataDao obj)
        {
            this.StopAllMusics();
        }

        private void StopAllMusics()
        {
            this.baseAudioSource.Stop();
        }

        private void OnGameplayStarts(GameDataDao obj)
        {
            this.baseAudioSource.clip = this.baseMusic;
            this.baseAudioSource.time = 0;
            this.baseAudioSource.Play();
        }
    }
}