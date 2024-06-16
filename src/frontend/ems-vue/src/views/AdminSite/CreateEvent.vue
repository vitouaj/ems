<template>
    <div>
      <v-card>
        <v-card-title class="font-weight-bold" style="color:#004B8D">
          Event Card
        </v-card-title>
        <v-card-item>
          <v-row>
            <v-col cols="12" class="pb-0">
              <label for="eventName" class="labelText">Event Name</label><br />
              <v-text-field v-model="newEvent.name" variant="solo" density="compact" placeholder="e.g name of event"></v-text-field>
            </v-col>
            <v-col cols="6" class="pb-0">
              <label for="StartDate" class="labelText">Start Date</label><br />
              <v-text-field v-model="newEvent.start_date" variant="solo" density="compact" placeholder="DD/MM/YYYY"></v-text-field>
            </v-col>
            <v-col cols="6" class="pb-0">
              <label for="eventSessions" class="labelText">Event Sessions</label><br />
              <session-dialog @update-sessions="updateSessions"></session-dialog>
            </v-col>
            <v-col cols="6" class="pb-0">
              <label for="EndDate" class="labelText">End Date</label><br />
              <v-text-field v-model="newEvent.end_date" variant="solo" density="compact" placeholder="DD/MM/YYYY"></v-text-field>
            </v-col>
            <v-col cols="12" class="pb-0">
              <label for="Description" class="labelText">Description</label><br />
              <v-textarea v-model="newEvent.description" row-height="20" rows="2" auto-grow variant="solo" placeholder="type your description here..."></v-textarea>
            </v-col>
            <v-col cols="12" class="pb-0">
              <label for="Map" class="labelText">Map</label><br />
              <v-text-field v-model="newEvent.location" variant="solo" density="compact" placeholder="type your location"></v-text-field>
            </v-col>
            <v-col cols="6">
              <label for="Tag" class="labelText">Tag</label><br />
              <v-autocomplete v-model="newEvent.tag" :items="items" density="compact" variant="solo"></v-autocomplete>
            </v-col>
            <v-col cols="6">
              <label for="Participator" class="labelText">Participator</label><br />
              <v-text-field v-model="newEvent.participators" variant="solo" density="compact" placeholder="start Date"></v-text-field>
            </v-col>
            <v-col cols="12">
              <label for="Image" class="labelText">Image</label><br />
              <v-file-input v-model="newEvent.image" variant="solo" density="compact" label="add image" prepend-icon=""></v-file-input>
            </v-col>
          </v-row>
        </v-card-item>
        <v-card-actions class="d-flex justify-end">
          <v-btn variant="elevated" color="#004B8D" @click="discardEvent">Discard</v-btn>
          <v-btn variant="elevated" color="#FF7F00" @click="postEvent" :disabled="!isFormValid">Post</v-btn>
        </v-card-actions>
      </v-card>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  import { v4 as uuidv4 } from 'uuid';
  import SessionDialog from './components/SessionDiol.vue'; // Ensure the path is correct
  
  export default {
    components: {
      SessionDialog
    },
    data() {
      return {
        items: ['education', 'workshop', 'fizz', 'buzz'],
        newEvent: {
          id: null,
          name: null,
          author: null,
          tag: null,
          participators: null,
          time: null,
          start_date: null,
          end_date: null,
          location: null,
          viewer: 0,
          description: null,
          session: [], // Array to hold sessions
          image: [] // Array to hold images
        }
      };
    },
    computed: {
      isFormValid() {
        const { name, start_date, end_date, description, location, tag, participators, image } = this.newEvent;
        return name && start_date && end_date && description && location && tag && participators && image.length > 0;
      }
    },
    methods: {
      discardEvent() {
        // Reset newEvent object to clear form inputs
        this.newEvent = {
          id: null,
          name: null,
          author: null,
          tag: null,
          participators: null,
          time: null,
          start_date: null,
          end_date: null,
          location: null,
          viewer: 0,
          description: null,
          session: [],
          image: []
        };
      },
      async postEvent() {
        // Generate a unique ID for the new event
        this.newEvent.id = uuidv4();
  
        // Simulate posting event data (you can send it to a server here)
        console.log('Posting event:', this.newEvent);
        
        await axios.post('http://localhost:3001/events', this.newEvent)
          .then(response => {
            console.log('Event posted successfully:', response.data);
            // Optionally, you can update the eventData with newEvent values
            this.$emit('update:eventData', this.newEvent);
  
            // Reset newEvent object after posting
            this.discardEvent();
          })
          .catch(error => {
            console.error('Error posting event:', error);
          });
      },
      updateSessions(sessions) {
        this.newEvent.session = sessions;
      }
    }
  };
  </script>
  
