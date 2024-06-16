<template>
    <div>
      <v-row>
        <p class="font-weight-bold">All Events</p>
      </v-row>
      <v-row>
        <v-col v-for="event in eventLists" :key="event.id" cols="4">
          <event-card :event="event" />
        </v-col>
      </v-row>
    </div>
  </template>
  
  <script>
  import axios from "axios";
  import EventCard from './components/EventCard.vue';
  
  export default {
    components: {
      EventCard
    },
    data() {
      return {
        eventLists: []
      }
    },
    async mounted() {
      try {
        const response = await axios.get("http://localhost:3001/events");
        this.eventLists = response.data;
      } catch (error) {
        console.error("Error fetching events:", error);
      }
    }
  }
  </script>
  
  <style>
  /* Add your styles here if needed */
  </style>
  
