<template>
    <div>
      <v-row v-if="eventDetails">
        <v-col cols="12" class="d-flex align-start">
          <div>
            <h2 class="font-weight-bold text-uppercase">{{ eventDetails.name }}</h2>
            <p class="text-caption">by: {{ eventDetails.author }}</p>
          </div>
          <div class="pt-1">
            <v-chip class="rounded-lg mx-1" size="x-small" variant="elevated" color="#7CB518">
              <v-icon size="small">mdi-alarm</v-icon><span>start at {{ eventDetails.time }}</span>
            </v-chip>
            <v-chip class="rounded-lg mx-1" size="x-small" variant="elevated" color="#FF7F00">
              <p>{{ eventDetails.tag }}</p>
            </v-chip>
          </div>
        </v-col>
        <v-col cols="12">
            <v-carousel>
            <v-carousel-item v-for="(imageUrl, index) in eventDetails.image" :key="index" :src="imageUrl" cover></v-carousel-item>
            </v-carousel>
        </v-col>
        <v-col cols="12" class="d-flex justify-center">
          <v-card min-width="110" class="mx-2 pa-2 d-flex align-center flex-column smallDetailBox">
            <v-icon size="x-large" color="#004B8D">mdi-account-group-outline</v-icon>
            <p>Participator</p>
            <p>{{ eventDetails.participators }}</p>
          </v-card>
          <v-card min-width="110" class="mx-2 pa-2 d-flex flex-column align-center smallDetailBox">
            <v-icon size="x-large" color="#004B8D">mdi-glasses</v-icon>
            <p>viewers</p>
            <p>{{ eventDetails.viewer }}</p>
          </v-card>
          <v-card min-width="110" class="mx-2 pa-2 d-flex flex-column align-center smallDetailBox">
            <v-icon size="x-large" color="#004B8D">mdi-clipboard-text-outline</v-icon>
            <p>Session</p>
            <p>
              <v-btn variant="text" text="view">View</v-btn>
            </p>
          </v-card>
        </v-col>
        <v-col cols="12">
          <h3 class="font-weight-bold">Description</h3>
          <p>{{ eventDetails.description }}</p>
        </v-col>
        <v-col cols="6">
          <v-row>
            <v-col cols="12" class="d-flex">
              <p><span class="font-weight-bold">Start Date: </span>{{ eventDetails.start_date }}</p>
            </v-col>
            <v-col cols="12">
              <p><span class="font-weight-bold">End Date: </span>{{ eventDetails.end_date }}</p>
            </v-col>
            <v-col cols="12">
              <p><span class="font-weight-bold">Time: </span>{{ eventDetails.time }}</p>
            </v-col>
            <v-col cols="12">
              <p><span class="font-weight-bold">Map: </span>{{ eventDetails.location }}</p>
            </v-col>
          </v-row>
        </v-col>
        <v-col cols="6">
          <iframe
            :src="`https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d62534.89697091127!2d104.82653816787605!3d11.592585684062556!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3109519fe4077d69%3A0x20138e822e434660!2sRoyal%20University%20of%20Phnom%20Penh!5e0!3m2!1sen!2skh!4v1715510130198!5m2!1sen!2skh`"
            width="100%" height="200" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade">
          </iframe>
        </v-col>
        <v-col cols="12" class="d-flex justify-end">
          <v-btn class="mx-2" color="#004B8D">
            <v-icon>mdi-delete</v-icon>Delete
          </v-btn>
          <v-btn color="#FF7F00">
            <v-icon>mdi-pen</v-icon>Edit
          </v-btn>
        </v-col>
      </v-row>
    </div>
  </template>
  
  <script>
  import axios from "axios";
  
  export default {
    data() {
      return {
        eventDetails: null,
      };
    },
    async mounted() {
      try {
        const eventId = this.$route.params.id;
        const response = await axios.get(`http://localhost:3001/events/${eventId}`);
        this.eventDetails = response.data;
      } catch (error) {
        console.error("Error fetching event details:", error);
      }
    },
  };
  </script>
  
  <style>
  .smallDetailBox {
    border: 1px solid rgba(255, 127, 0, 0.2);
    box-shadow: 2px 5px 1px rgba(255, 127, 0, 0.2);
  }
  </style>
  
